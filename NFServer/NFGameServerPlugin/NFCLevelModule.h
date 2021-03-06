// -------------------------------------------------------------------------
//    @FileName      :    NFCLevelModule.h
//    @Author           :    LvSheng.Huang
//    @Date             :    2013-09-28
//    @Module           :    NFCLevelModule
//
// -------------------------------------------------------------------------

#ifndef _NFC_LEVEL_MODULE_H_
#define _NFC_LEVEL_MODULE_H_

#include "NFComm/NFPluginModule/NFIKernelModule.h"
#include "NFComm/NFPluginModule/NFIGameLogicModule.h"
#include "NFComm/NFPluginModule/NFIEventProcessModule.h"
#include "NFComm/NFPluginModule/NFILevelModule.h"
#include "NFComm/NFPluginModule/NFILogModule.h"
#include "NFComm/NFPluginModule/NFIPropertyConfigModule.h"
#include "NFComm/NFPluginModule/NFIPluginManager.h"

class NFCLevelModule
    : public NFILevelModule
{
public:
    NFCLevelModule( NFIPluginManager* p )
    {
        pPluginManager = p;
    }
    virtual ~NFCLevelModule() {};

    virtual bool Init();
    virtual bool Shut();
    virtual bool Execute( const float fLasFrametime, const float fStartedTime );
    virtual bool AfterInit();

    virtual int AddExp( const NFIDENTID& self, const int nExp);

    virtual int OnKillObject( const NFIDENTID& self, const NFIDENTID& other );

    virtual int OnDead( const NFIDENTID& self, const NFIDENTID& other );

protected:

    int OnObjectClassEvent( const NFIDENTID& self, const std::string& strClassName, const CLASS_OBJECT_EVENT eClassEvent, const NFIDataList& var );

    int OnObjectExpEvent( const NFIDENTID& self, const std::string& strPropertyName, const NFIDataList& oldVar, const NFIDataList& newVar, const NFIDataList& argVar );

    int OnObjectBeKilled( const NFIDENTID& object, const int nEventID, const NFIDataList& var );

private:
    NFIPropertyConfigModule* m_pPropertyConfigModule;
    NFIEventProcessModule* m_pEventProcessModule;
    NFIKernelModule* m_pKernelModule;
    NFILogModule* m_pLogModule;

};


#endif
