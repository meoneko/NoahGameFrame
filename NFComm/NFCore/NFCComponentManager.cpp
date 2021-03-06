// -------------------------------------------------------------------------
//    @FileName         :    NFCComponentManager.cpp
//    @Author           :    LvSheng.Huang
//    @Date             :    2014-02-17
//    @Module           :    NFCComponentManager
//
// -------------------------------------------------------------------------

#include "NFCComponentManager.h"

NFIDENTID NFCComponentManager::Self()
{
    return mSelf;
}

bool NFCComponentManager::AddComponent(const std::string& strComponentName, NF_SHARE_PTR<NFIComponent> pNewComponent)
{
    return AddElement(strComponentName, pNewComponent);
}

bool NFCComponentManager::Init()
{
    NF_SHARE_PTR<NFIComponent> pComponent = First();
    while (nullptr != pComponent)
    {
        pComponent->Init();

        pComponent = Next();
    }

    return true;
}

bool NFCComponentManager::AfterInit()
{
    NF_SHARE_PTR<NFIComponent> pComponent = First();
    while (pComponent.get())
    {
        pComponent->AfterInit();

        pComponent = Next();
    }

    return true;
}

bool NFCComponentManager::BeforeShut()
{
    NF_SHARE_PTR<NFIComponent> pComponent = First();
    while (pComponent.get())
    {
        pComponent->BeforeShut();

        pComponent = Next();
    }

    return true;
}

bool NFCComponentManager::Shut()
{
    NF_SHARE_PTR<NFIComponent> pComponent = First();
    while (pComponent.get())
    {
        pComponent->Shut();

        pComponent = Next();
    }

    return true;
}

bool NFCComponentManager::Execute(const float fLasFrametime, const float fStartedTime)
{

    NF_SHARE_PTR<NFIComponent> pComponent = First();
    while (pComponent.get() && pComponent->Enable())
    {
        pComponent->Execute(fLasFrametime, fStartedTime);

        pComponent = Next();
    }

    return true;
}
