// -------------------------------------------------------------------------
//    @FileName      :    NFCPropertyTrailModule.cpp
//    @Author           :    LvSheng.Huang
//    @Date             :    2013-09-30
//    @Module           :    NFCPropertyTrailModule
//
// -------------------------------------------------------------------------

#include "NFCPropertyTrailModule.h"
#include "NFComm/NFPluginModule/NFIPluginManager.h"
#include "NFComm/NFCore/NFCDataList.h"

bool NFCPropertyTrailModule::Init()
{

    return true;
}


bool NFCPropertyTrailModule::Shut()
{
    return true;
}

bool NFCPropertyTrailModule::Execute( const float fLasFrametime, const float fStartedTime )
{
    return true;
}

bool NFCPropertyTrailModule::AfterInit()
{
	m_pEventProcessModule = dynamic_cast<NFIEventProcessModule*>( pPluginManager->FindModule( "NFCEventProcessModule" ) );
	m_pKernelModule = dynamic_cast<NFIKernelModule*>( pPluginManager->FindModule( "NFCKernelModule" ) );
	m_pElementInfoModule = dynamic_cast<NFIElementInfoModule*>( pPluginManager->FindModule( "NFCElementInfoModule" ) );
	m_pLogicClassModule = dynamic_cast<NFILogicClassModule*>( pPluginManager->FindModule( "NFCLogicClassModule" ) );
	m_pPropertyConfigModule = dynamic_cast<NFIPropertyConfigModule*>( pPluginManager->FindModule( "NFCPropertyConfigModule" ) );
	m_pLogModule = dynamic_cast<NFILogModule*>( pPluginManager->FindModule( "NFCLogModule" ) );
	
	assert( NULL != m_pEventProcessModule );
	assert( NULL != m_pKernelModule );
	assert( NULL != m_pElementInfoModule );
	assert( NULL != m_pLogicClassModule );
	assert( NULL != m_pPropertyConfigModule );
	assert( NULL != m_pLogModule );


    return true;
}

void NFCPropertyTrailModule::StartTrail( const NFIDENTID self )
{
	LogObjectData(self);

	
}

void NFCPropertyTrailModule::EndTrail( const NFIDENTID self )
{

}

int NFCPropertyTrailModule::LogObjectData( const NFIDENTID& self )
{
	NF_SHARE_PTR<NFIObject> xObject = m_pKernelModule->GetObject(self);
	if (nullptr == xObject)
	{
		return -1;
	}

	NF_SHARE_PTR<NFIPropertyManager> xPropertyManager = xObject->GetPropertyManager();
	if (nullptr != xPropertyManager)
	{
		NF_SHARE_PTR<NFIProperty> xProperty = xPropertyManager->First();
		while (nullptr != xProperty)
		{
			std::ostringstream stream;
			
			stream << " Start trail ";
			stream << xProperty->ToString();

			m_pLogModule->LogProperty(NFILogModule::NF_LOG_LEVEL::NLL_INFO_NORMAL, self, xProperty->GetKey(), stream.str(),  __FUNCTION__, __LINE__);

			xProperty = xPropertyManager->Next();
		}
	}

	NF_SHARE_PTR<NFIRecordManager> xRecordManager = xObject->GetRecordManager();
	if (nullptr != xRecordManager)
	{
		NF_SHARE_PTR<NFIRecord> xRecord = xRecordManager->First();
		while (nullptr != xRecord)
		{
			for (int i = 0; i < xRecord->GetRows(); ++i)
			{
				NFCDataList xDataList;
				bool bRet = xRecord->QueryRow(i, xDataList);
				if (bRet)
				{
					std::ostringstream stream;
					stream << " Start trail Row[" << i << "]";

					for (int j = 0; j < xDataList.GetCount(); ++j)
					{
						stream << " [" << j << "] " << xDataList.StringValEx(j);
					}

					m_pLogModule->LogRecord(NFILogModule::NF_LOG_LEVEL::NLL_INFO_NORMAL, self, xRecord->GetName(), stream.str(),  __FUNCTION__, __LINE__);
				}
			}
			
			xRecord = xRecordManager->Next();
		}
	}

	return 0;
}

int NFCPropertyTrailModule::OnObjectPropertyEvent( const NFIDENTID& self, const std::string& strPropertyName, const NFIDataList::TData& oldVar, const NFIDataList::TData& newVar )
{
	std::ostringstream stream;

	stream << " Trailing ";
	stream << " [Old] ";
	stream << oldVar.String();
	stream << " [New] ";
	stream << newVar.String();

	m_pLogModule->LogProperty(NFILogModule::NF_LOG_LEVEL::NLL_INFO_NORMAL, self, strPropertyName, stream.str(),  __FUNCTION__, __LINE__);

	return 0;
}

int NFCPropertyTrailModule::OnObjectRecordEvent( const NFIDENTID& self, const RECORD_EVENT_DATA& xEventData, const NFIDataList& oldVar, const NFIDataList& newVar )
{
	std::ostringstream stream;
	NF_SHARE_PTR<NFIRecord> xRecord = m_pKernelModule->FindRecord(self, xEventData.strRecordName);
	if (nullptr == xRecord)
	{
		return 0;
	}

	switch (xEventData.nOpType)
	{
	case NFIRecord::RecordOptype::Add:
		{
			NFCDataList xDataList;
			bool bRet = xRecord->QueryRow(xEventData.nRow, xDataList);
			if (bRet)
			{
				stream << " Trail Add Row[" << xEventData.nRow << "]";

				for (int j = 0; j < xDataList.GetCount(); ++j)
				{
					stream << " [" << j << "] " << xDataList.StringValEx(j);
				}

				m_pLogModule->LogRecord(NFILogModule::NF_LOG_LEVEL::NLL_INFO_NORMAL, self, xRecord->GetName(), stream.str(),  __FUNCTION__, __LINE__);
			}
		}
		break;
	case NFIRecord::RecordOptype::Del:
		{
			stream << " Trail Del Row[" << xEventData.nRow << "]";
			m_pLogModule->LogRecord(NFILogModule::NF_LOG_LEVEL::NLL_INFO_NORMAL, self, xRecord->GetName(), stream.str(),  __FUNCTION__, __LINE__);
		}
		break;
	case NFIRecord::RecordOptype::Swap:
		{
			stream << " Trail Swap Row[" << xEventData.nRow << "] Row[" << xEventData.nCol << "]";
			m_pLogModule->LogRecord(NFILogModule::NF_LOG_LEVEL::NLL_INFO_NORMAL, self, xRecord->GetName(), stream.str(),  __FUNCTION__, __LINE__);
		}
		break;
	case NFIRecord::RecordOptype::Create:
		break;
	case NFIRecord::RecordOptype::UpData:
		{
			stream << " Trail UpData Row[" << xEventData.nRow << "] Col[" << xEventData.nCol << "]";
			stream << " [Old] " << oldVar.StringValEx(0);
			stream << " [New] " << newVar.StringValEx(0);
			m_pLogModule->LogRecord(NFILogModule::NF_LOG_LEVEL::NLL_INFO_NORMAL, self, xRecord->GetName(), stream.str(),  __FUNCTION__, __LINE__);
		}
		break;
	case NFIRecord::RecordOptype::Cleared:
		break;
	case NFIRecord::RecordOptype::Sort:
		break;
	default:
		break;
	}

	return 0;
}

int NFCPropertyTrailModule::TrailObjectData( const NFIDENTID& self )
{
	NF_SHARE_PTR<NFIObject> xObject = m_pKernelModule->GetObject(self);
	if (nullptr == xObject)
	{
		return -1;
	}

	NF_SHARE_PTR<NFIPropertyManager> xPropertyManager = xObject->GetPropertyManager();
	if (nullptr != xPropertyManager)
	{
		NF_SHARE_PTR<NFIProperty> xProperty = xPropertyManager->First();
		while (nullptr != xProperty)
		{
			m_pKernelModule->AddPropertyCallBack(self, xProperty->GetKey(), this, &NFCPropertyTrailModule::OnObjectPropertyEvent);

			xProperty = xPropertyManager->Next();
		}
	}

	NF_SHARE_PTR<NFIRecordManager> xRecordManager = xObject->GetRecordManager();
	if (nullptr != xRecordManager)
	{
		NF_SHARE_PTR<NFIRecord> xRecord = xRecordManager->First();
		while (nullptr != xRecord)
		{
			m_pKernelModule->AddRecordCallBack(self, xRecord->GetName(), this, &NFCPropertyTrailModule::OnObjectRecordEvent);


			xRecord = xRecordManager->Next();
		}
	}

	return 0;
}
