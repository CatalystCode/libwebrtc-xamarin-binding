using System;
using Android.Runtime;

namespace Org.Webrtc
{
    public partial class EglBaseFactory : global::Java.Lang.Object
    {
        static IntPtr id_create_Lorg_webrtc_EglBase_Context_arrayI;

        [Register("create$$STATIC$$", "(Lorg/webrtc/EglBase$Context;[I)Lorg/webrtc/EglBase;", "")]
        public static unsafe global::Org.Webrtc.IEglBase Create(global::Org.Webrtc.EglBaseContext sharedContext, int[] configAttributes)
        {
            if (id_create_Lorg_webrtc_EglBase_Context_arrayI == IntPtr.Zero)
				id_create_Lorg_webrtc_EglBase_Context_arrayI = JNIEnv.GetStaticMethodID(class_ref, "create$$STATIC$$", "(Lorg/webrtc/EglBase$Context;[I)Lorg/webrtc/EglBase;");
            IntPtr native_configAttributes = JNIEnv.NewArray(configAttributes);
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(sharedContext);
                __args[1] = new JValue(native_configAttributes);
                global::Org.Webrtc.IEglBase __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IEglBase>(JNIEnv.CallStaticObjectMethod(class_ref, id_create_Lorg_webrtc_EglBase_Context_arrayI, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
                if (configAttributes != null)
                {
                    JNIEnv.CopyArray(native_configAttributes, configAttributes);
                    JNIEnv.DeleteLocalRef(native_configAttributes);
                }
            }
        }

    }
}
