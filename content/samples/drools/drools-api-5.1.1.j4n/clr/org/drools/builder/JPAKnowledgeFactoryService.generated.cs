//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.builder {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface JPAKnowledgeFactoryService {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/KnowledgeBase;Lorg/drools/runtime/KnowledgeSessionConfiguration;Lorg" +
            "/drools/runtime/Environment;)Lorg/drools/runtime/StatefulKnowledgeSession;")]
        global::org.drools.runtime.StatefulKnowledgeSession newStatefulKnowledgeSession(global::org.drools.KnowledgeBase par0, global::org.drools.runtime.KnowledgeSessionConfiguration par1, global::org.drools.runtime.Environment par2);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(ILorg/drools/KnowledgeBase;Lorg/drools/runtime/KnowledgeSessionConfiguration;Lor" +
            "g/drools/runtime/Environment;)Lorg/drools/runtime/StatefulKnowledgeSession;")]
        global::org.drools.runtime.StatefulKnowledgeSession loadStatefulKnowledgeSession(int par0, global::org.drools.KnowledgeBase par1, global::org.drools.runtime.KnowledgeSessionConfiguration par2, global::org.drools.runtime.Environment par3);
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class JPAKnowledgeFactoryService_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.builder.@__JPAKnowledgeFactoryService.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.builder.JPAKnowledgeFactoryService), typeof(global::org.drools.builder.JPAKnowledgeFactoryService_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.builder.JPAKnowledgeFactoryService), typeof(global::org.drools.builder.JPAKnowledgeFactoryService_))]
    internal sealed partial class @__JPAKnowledgeFactoryService : global::java.lang.Object, global::org.drools.builder.JPAKnowledgeFactoryService {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _newStatefulKnowledgeSession0;
        
        internal static global::net.sf.jni4net.jni.MethodId _loadStatefulKnowledgeSession1;
        
        private @__JPAKnowledgeFactoryService(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.builder.@__JPAKnowledgeFactoryService.staticClass = @__class;
            global::org.drools.builder.@__JPAKnowledgeFactoryService._newStatefulKnowledgeSession0 = @__env.GetMethodID(global::org.drools.builder.@__JPAKnowledgeFactoryService.staticClass, "newStatefulKnowledgeSession", "(Lorg/drools/KnowledgeBase;Lorg/drools/runtime/KnowledgeSessionConfiguration;Lorg" +
                    "/drools/runtime/Environment;)Lorg/drools/runtime/StatefulKnowledgeSession;");
            global::org.drools.builder.@__JPAKnowledgeFactoryService._loadStatefulKnowledgeSession1 = @__env.GetMethodID(global::org.drools.builder.@__JPAKnowledgeFactoryService.staticClass, "loadStatefulKnowledgeSession", "(ILorg/drools/KnowledgeBase;Lorg/drools/runtime/KnowledgeSessionConfiguration;Lor" +
                    "g/drools/runtime/Environment;)Lorg/drools/runtime/StatefulKnowledgeSession;");
        }
        
        public global::org.drools.runtime.StatefulKnowledgeSession newStatefulKnowledgeSession(global::org.drools.KnowledgeBase par0, global::org.drools.runtime.KnowledgeSessionConfiguration par1, global::org.drools.runtime.Environment par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 16)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.StatefulKnowledgeSession>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.builder.@__JPAKnowledgeFactoryService._newStatefulKnowledgeSession0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.KnowledgeBase>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.runtime.KnowledgeSessionConfiguration>(@__env, par1), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.runtime.Environment>(@__env, par2)));
            }
        }
        
        public global::org.drools.runtime.StatefulKnowledgeSession loadStatefulKnowledgeSession(int par0, global::org.drools.KnowledgeBase par1, global::org.drools.runtime.KnowledgeSessionConfiguration par2, global::org.drools.runtime.Environment par3) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 18)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.StatefulKnowledgeSession>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.builder.@__JPAKnowledgeFactoryService._loadStatefulKnowledgeSession1, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.KnowledgeBase>(@__env, par1), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.runtime.KnowledgeSessionConfiguration>(@__env, par2), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.runtime.Environment>(@__env, par3)));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__JPAKnowledgeFactoryService);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "newStatefulKnowledgeSession", "newStatefulKnowledgeSession0", "(Lorg/drools/KnowledgeBase;Lorg/drools/runtime/KnowledgeSessionConfiguration;Lorg" +
                        "/drools/runtime/Environment;)Lorg/drools/runtime/StatefulKnowledgeSession;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "loadStatefulKnowledgeSession", "loadStatefulKnowledgeSession1", "(ILorg/drools/KnowledgeBase;Lorg/drools/runtime/KnowledgeSessionConfiguration;Lor" +
                        "g/drools/runtime/Environment;)Lorg/drools/runtime/StatefulKnowledgeSession;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle newStatefulKnowledgeSession0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0, global::net.sf.jni4net.utils.JniLocalHandle par1, global::net.sf.jni4net.utils.JniLocalHandle par2) {
            // (Lorg/drools/KnowledgeBase;Lorg/drools/runtime/KnowledgeSessionConfiguration;Lorg/drools/runtime/Environment;)Lorg/drools/runtime/StatefulKnowledgeSession;
            // (Lorg/drools/KnowledgeBase;Lorg/drools/runtime/KnowledgeSessionConfiguration;Lorg/drools/runtime/Environment;)Lorg/drools/runtime/StatefulKnowledgeSession;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.builder.JPAKnowledgeFactoryService @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.builder.JPAKnowledgeFactoryService>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.runtime.StatefulKnowledgeSession>(@__env, @__real.newStatefulKnowledgeSession(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.KnowledgeBase>(@__env, par0), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.KnowledgeSessionConfiguration>(@__env, par1), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.Environment>(@__env, par2)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle loadStatefulKnowledgeSession1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, int par0, global::net.sf.jni4net.utils.JniLocalHandle par1, global::net.sf.jni4net.utils.JniLocalHandle par2, global::net.sf.jni4net.utils.JniLocalHandle par3) {
            // (ILorg/drools/KnowledgeBase;Lorg/drools/runtime/KnowledgeSessionConfiguration;Lorg/drools/runtime/Environment;)Lorg/drools/runtime/StatefulKnowledgeSession;
            // (ILorg/drools/KnowledgeBase;Lorg/drools/runtime/KnowledgeSessionConfiguration;Lorg/drools/runtime/Environment;)Lorg/drools/runtime/StatefulKnowledgeSession;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.builder.JPAKnowledgeFactoryService @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.builder.JPAKnowledgeFactoryService>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.runtime.StatefulKnowledgeSession>(@__env, @__real.loadStatefulKnowledgeSession(par0, global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.KnowledgeBase>(@__env, par1), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.KnowledgeSessionConfiguration>(@__env, par2), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.Environment>(@__env, par3)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.builder.@__JPAKnowledgeFactoryService(@__env);
            }
        }
    }
    #endregion
}
