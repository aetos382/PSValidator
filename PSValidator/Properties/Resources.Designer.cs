﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34014
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSValidator.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PSValidator.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   厳密に型指定されたこのリソース クラスを使用して、すべての検索リソースに対し、
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   The argument is empty. Provide an argument that is not empty, and then try the command again. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ArgumentIsEmptyString {
            get {
                return ResourceManager.GetString("ArgumentIsEmptyString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   The ValidateNotNullOrEmptyString attribute cannot be applied to a parameter that is not a string or string[] parameter. Make the parameter a string or string[] parameter. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ArgumentIsNotString {
            get {
                return ResourceManager.GetString("ArgumentIsNotString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   The argument is null. Provide a valid value for the argument, and then try running the command again. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ArgumentIsNull {
            get {
                return ResourceManager.GetString("ArgumentIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   PathType.Container was specified, but path &apos;{0}&apos; is not a container object. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string PathIsNotContainer {
            get {
                return ResourceManager.GetString("PathIsNotContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   PathType.Leaf was specified, but path &apos;{0}&apos; is not a leaf object. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string PathIsNotLeaf {
            get {
                return ResourceManager.GetString("PathIsNotLeaf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Path &apos;{0}&apos; does not exist. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string PathNotExists {
            get {
                return ResourceManager.GetString("PathNotExists", resourceCulture);
            }
        }
    }
}
