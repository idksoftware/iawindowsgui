

/* this ALWAYS GENERATED file contains the proxy stub code */


 /* File created by MIDL compiler version 8.01.0626 */
/* at Tue Jan 19 03:14:07 2038
 */
/* Compiler settings for IACkoutIcon.idl:
    Oicf, W1, Zp8, env=Win64 (32b run), target_arch=AMD64 8.01.0626 
    protocol : all , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
/* @@MIDL_FILE_HEADING(  ) */

#if defined(_M_AMD64)


#if _MSC_VER >= 1200
#pragma warning(push)
#endif

#pragma warning( disable: 4211 )  /* redefine extern to static */
#pragma warning( disable: 4232 )  /* dllimport identity*/
#pragma warning( disable: 4024 )  /* array to pointer mapping*/
#pragma warning( disable: 4152 )  /* function/data pointer conversion in expression */

#define USE_STUBLESS_PROXY


/* verify that the <rpcproxy.h> version is high enough to compile this file*/
#ifndef __REDQ_RPCPROXY_H_VERSION__
#define __REQUIRED_RPCPROXY_H_VERSION__ 475
#endif


#include "rpcproxy.h"
#include "ndr64types.h"
#ifndef __RPCPROXY_H_VERSION__
#error this stub requires an updated version of <rpcproxy.h>
#endif /* __RPCPROXY_H_VERSION__ */


#include "IACkoutIcon_i.h"

#define TYPE_FORMAT_STRING_SIZE   3                                 
#define PROC_FORMAT_STRING_SIZE   1                                 
#define EXPR_FORMAT_STRING_SIZE   1                                 
#define TRANSMIT_AS_TABLE_SIZE    0            
#define WIRE_MARSHAL_TABLE_SIZE   0            

typedef struct _IACkoutIcon_MIDL_TYPE_FORMAT_STRING
    {
    short          Pad;
    unsigned char  Format[ TYPE_FORMAT_STRING_SIZE ];
    } IACkoutIcon_MIDL_TYPE_FORMAT_STRING;

typedef struct _IACkoutIcon_MIDL_PROC_FORMAT_STRING
    {
    short          Pad;
    unsigned char  Format[ PROC_FORMAT_STRING_SIZE ];
    } IACkoutIcon_MIDL_PROC_FORMAT_STRING;

typedef struct _IACkoutIcon_MIDL_EXPR_FORMAT_STRING
    {
    long          Pad;
    unsigned char  Format[ EXPR_FORMAT_STRING_SIZE ];
    } IACkoutIcon_MIDL_EXPR_FORMAT_STRING;


static const RPC_SYNTAX_IDENTIFIER  _RpcTransferSyntax = 
{{0x8A885D04,0x1CEB,0x11C9,{0x9F,0xE8,0x08,0x00,0x2B,0x10,0x48,0x60}},{2,0}};

static const RPC_SYNTAX_IDENTIFIER  _NDR64_RpcTransferSyntax = 
{{0x71710533,0xbeba,0x4937,{0x83,0x19,0xb5,0xdb,0xef,0x9c,0xcc,0x36}},{1,0}};

#if defined(_CONTROL_FLOW_GUARD_XFG)
#define XFG_TRAMPOLINES(ObjectType)\
static unsigned long ObjectType ## _UserSize_XFG(unsigned long * pFlags, unsigned long Offset, void * pObject)\
{\
return  ObjectType ## _UserSize(pFlags, Offset, pObject);\
}\
static unsigned char * ObjectType ## _UserMarshal_XFG(unsigned long * pFlags, unsigned char * pBuffer, void * pObject)\
{\
return ObjectType ## _UserMarshal(pFlags, pBuffer, pObject);\
}\
static unsigned char * ObjectType ## _UserUnmarshal_XFG(unsigned long * pFlags, unsigned char * pBuffer, void * pObject)\
{\
return ObjectType ## _UserUnmarshal(pFlags, pBuffer, pObject);\
}\
static void ObjectType ## _UserFree_XFG(unsigned long * pFlags, void * pObject)\
{\
ObjectType ## _UserFree(pFlags, pObject);\
}
#define XFG_TRAMPOLINES64(ObjectType)\
static unsigned long ObjectType ## _UserSize64_XFG(unsigned long * pFlags, unsigned long Offset, void * pObject)\
{\
return  ObjectType ## _UserSize64(pFlags, Offset, pObject);\
}\
static unsigned char * ObjectType ## _UserMarshal64_XFG(unsigned long * pFlags, unsigned char * pBuffer, void * pObject)\
{\
return ObjectType ## _UserMarshal64(pFlags, pBuffer, pObject);\
}\
static unsigned char * ObjectType ## _UserUnmarshal64_XFG(unsigned long * pFlags, unsigned char * pBuffer, void * pObject)\
{\
return ObjectType ## _UserUnmarshal64(pFlags, pBuffer, pObject);\
}\
static void ObjectType ## _UserFree64_XFG(unsigned long * pFlags, void * pObject)\
{\
ObjectType ## _UserFree64(pFlags, pObject);\
}
#define XFG_BIND_TRAMPOLINES(HandleType, ObjectType)\
static void* ObjectType ## _bind_XFG(HandleType pObject)\
{\
return ObjectType ## _bind((ObjectType) pObject);\
}\
static void ObjectType ## _unbind_XFG(HandleType pObject, handle_t ServerHandle)\
{\
ObjectType ## _unbind((ObjectType) pObject, ServerHandle);\
}
#define XFG_TRAMPOLINE_FPTR(Function) Function ## _XFG
#else
#define XFG_TRAMPOLINES(ObjectType)
#define XFG_TRAMPOLINES64(ObjectType)
#define XFG_BIND_TRAMPOLINES(HandleType, ObjectType)
#define XFG_TRAMPOLINE_FPTR(Function) Function
#endif



extern const IACkoutIcon_MIDL_TYPE_FORMAT_STRING IACkoutIcon__MIDL_TypeFormatString;
extern const IACkoutIcon_MIDL_PROC_FORMAT_STRING IACkoutIcon__MIDL_ProcFormatString;
extern const IACkoutIcon_MIDL_EXPR_FORMAT_STRING IACkoutIcon__MIDL_ExprFormatString;


extern const MIDL_STUB_DESC Object_StubDesc;


extern const MIDL_SERVER_INFO ICkoutIcon_ServerInfo;
extern const MIDL_STUBLESS_PROXY_INFO ICkoutIcon_ProxyInfo;



#if !defined(__RPC_WIN64__)
#error  Invalid build platform for this stub.
#endif

static const IACkoutIcon_MIDL_PROC_FORMAT_STRING IACkoutIcon__MIDL_ProcFormatString =
    {
        0,
        {

			0x0
        }
    };

static const IACkoutIcon_MIDL_TYPE_FORMAT_STRING IACkoutIcon__MIDL_TypeFormatString =
    {
        0,
        {
			NdrFcShort( 0x0 ),	/* 0 */

			0x0
        }
    };


/* Object interface: IUnknown, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0xC0,0x00,0x00,0x00,0x00,0x00,0x00,0x46}} */


/* Object interface: IDispatch, ver. 0.0,
   GUID={0x00020400,0x0000,0x0000,{0xC0,0x00,0x00,0x00,0x00,0x00,0x00,0x46}} */


/* Object interface: ICkoutIcon, ver. 0.0,
   GUID={0x8ab5cc4c,0x4950,0x44d9,{0x91,0xf3,0x6c,0xde,0x6f,0xce,0xfc,0x5e}} */

#pragma code_seg(".orpc")
static const unsigned short ICkoutIcon_FormatStringOffsetTable[] =
    {
    (unsigned short) -1,
    (unsigned short) -1,
    (unsigned short) -1,
    (unsigned short) -1,
    0
    };



#endif /* defined(_M_AMD64)*/



/* this ALWAYS GENERATED file contains the proxy stub code */


 /* File created by MIDL compiler version 8.01.0626 */
/* at Tue Jan 19 03:14:07 2038
 */
/* Compiler settings for IACkoutIcon.idl:
    Oicf, W1, Zp8, env=Win64 (32b run), target_arch=AMD64 8.01.0626 
    protocol : all , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
/* @@MIDL_FILE_HEADING(  ) */

#if defined(_M_AMD64)




#if !defined(__RPC_WIN64__)
#error  Invalid build platform for this stub.
#endif


#include "ndr64types.h"
#include "pshpack8.h"


typedef 
NDR64_FORMAT_UINT32
__midl_frag1_t;
extern const __midl_frag1_t __midl_frag1;

static const __midl_frag1_t __midl_frag1 =
(NDR64_UINT32) 0 /* 0x0 */;


#include "poppack.h"



/* Object interface: IUnknown, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0xC0,0x00,0x00,0x00,0x00,0x00,0x00,0x46}} */


/* Object interface: IDispatch, ver. 0.0,
   GUID={0x00020400,0x0000,0x0000,{0xC0,0x00,0x00,0x00,0x00,0x00,0x00,0x46}} */


/* Object interface: ICkoutIcon, ver. 0.0,
   GUID={0x8ab5cc4c,0x4950,0x44d9,{0x91,0xf3,0x6c,0xde,0x6f,0xce,0xfc,0x5e}} */

#pragma code_seg(".orpc")
static const FormatInfoRef ICkoutIcon_Ndr64ProcTable[] =
    {
    (FormatInfoRef)(LONG_PTR) -1,
    (FormatInfoRef)(LONG_PTR) -1,
    (FormatInfoRef)(LONG_PTR) -1,
    (FormatInfoRef)(LONG_PTR) -1,
    0
    };


static const MIDL_SYNTAX_INFO ICkoutIcon_SyntaxInfo [  2 ] = 
    {
    {
    {{0x8A885D04,0x1CEB,0x11C9,{0x9F,0xE8,0x08,0x00,0x2B,0x10,0x48,0x60}},{2,0}},
    0,
    IACkoutIcon__MIDL_ProcFormatString.Format,
    &ICkoutIcon_FormatStringOffsetTable[-3],
    IACkoutIcon__MIDL_TypeFormatString.Format,
    0,
    0,
    0
    }
    ,{
    {{0x71710533,0xbeba,0x4937,{0x83,0x19,0xb5,0xdb,0xef,0x9c,0xcc,0x36}},{1,0}},
    0,
    0 ,
    (unsigned short *) &ICkoutIcon_Ndr64ProcTable[-3],
    0,
    0,
    0,
    0
    }
    };

static const MIDL_STUBLESS_PROXY_INFO ICkoutIcon_ProxyInfo =
    {
    &Object_StubDesc,
    IACkoutIcon__MIDL_ProcFormatString.Format,
    &ICkoutIcon_FormatStringOffsetTable[-3],
    (RPC_SYNTAX_IDENTIFIER*)&_RpcTransferSyntax,
    2,
    (MIDL_SYNTAX_INFO*)ICkoutIcon_SyntaxInfo
    
    };


static const MIDL_SERVER_INFO ICkoutIcon_ServerInfo = 
    {
    &Object_StubDesc,
    0,
    IACkoutIcon__MIDL_ProcFormatString.Format,
    (unsigned short *) &ICkoutIcon_FormatStringOffsetTable[-3],
    0,
    (RPC_SYNTAX_IDENTIFIER*)&_NDR64_RpcTransferSyntax,
    2,
    (MIDL_SYNTAX_INFO*)ICkoutIcon_SyntaxInfo
    };
CINTERFACE_PROXY_VTABLE(7) _ICkoutIconProxyVtbl = 
{
    0,
    &IID_ICkoutIcon,
    IUnknown_QueryInterface_Proxy,
    IUnknown_AddRef_Proxy,
    IUnknown_Release_Proxy ,
    0 /* IDispatch::GetTypeInfoCount */ ,
    0 /* IDispatch::GetTypeInfo */ ,
    0 /* IDispatch::GetIDsOfNames */ ,
    0 /* IDispatch_Invoke_Proxy */
};


static const PRPC_STUB_FUNCTION ICkoutIcon_table[] =
{
    STUB_FORWARDING_FUNCTION,
    STUB_FORWARDING_FUNCTION,
    STUB_FORWARDING_FUNCTION,
    STUB_FORWARDING_FUNCTION
};

CInterfaceStubVtbl _ICkoutIconStubVtbl =
{
    &IID_ICkoutIcon,
    &ICkoutIcon_ServerInfo,
    7,
    &ICkoutIcon_table[-3],
    CStdStubBuffer_DELEGATING_METHODS
};

static const MIDL_STUB_DESC Object_StubDesc = 
    {
    0,
    NdrOleAllocate,
    NdrOleFree,
    0,
    0,
    0,
    0,
    0,
    IACkoutIcon__MIDL_TypeFormatString.Format,
    1, /* -error bounds_check flag */
    0x60001, /* Ndr library version */
    0,
    0x8010272, /* MIDL Version 8.1.626 */
    0,
    0,
    0,  /* notify & notify_flag routine table */
    0x2000001, /* MIDL flag */
    0, /* cs routines */
    0,   /* proxy/server info */
    0
    };

const CInterfaceProxyVtbl * const _IACkoutIcon_ProxyVtblList[] = 
{
    ( CInterfaceProxyVtbl *) &_ICkoutIconProxyVtbl,
    0
};

const CInterfaceStubVtbl * const _IACkoutIcon_StubVtblList[] = 
{
    ( CInterfaceStubVtbl *) &_ICkoutIconStubVtbl,
    0
};

PCInterfaceName const _IACkoutIcon_InterfaceNamesList[] = 
{
    "ICkoutIcon",
    0
};

const IID *  const _IACkoutIcon_BaseIIDList[] = 
{
    &IID_IDispatch,
    0
};


#define _IACkoutIcon_CHECK_IID(n)	IID_GENERIC_CHECK_IID( _IACkoutIcon, pIID, n)

int __stdcall _IACkoutIcon_IID_Lookup( const IID * pIID, int * pIndex )
{
    
    if(!_IACkoutIcon_CHECK_IID(0))
        {
        *pIndex = 0;
        return 1;
        }

    return 0;
}

const ExtendedProxyFileInfo IACkoutIcon_ProxyFileInfo = 
{
    (PCInterfaceProxyVtblList *) & _IACkoutIcon_ProxyVtblList,
    (PCInterfaceStubVtblList *) & _IACkoutIcon_StubVtblList,
    (const PCInterfaceName * ) & _IACkoutIcon_InterfaceNamesList,
    (const IID ** ) & _IACkoutIcon_BaseIIDList,
    & _IACkoutIcon_IID_Lookup, 
    1,
    2,
    0, /* table of [async_uuid] interfaces */
    0, /* Filler1 */
    0, /* Filler2 */
    0  /* Filler3 */
};
#if _MSC_VER >= 1200
#pragma warning(pop)
#endif


#endif /* defined(_M_AMD64)*/

