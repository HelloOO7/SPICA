﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPICA.Rendering.Properties {
    using System;
    
    
    /// <summary>
    ///   Třída prostředků se silnými typy pro vyhledávání lokalizovaných řetězců atp.
    /// </summary>
    // Tato třída byla automaticky generována třídou StronglyTypedResourceBuilder
    // pomocí nástroje podobného aplikaci ResGen nebo Visual Studio.
    // Chcete-li přidat nebo odebrat člena, upravte souboru .ResX a pak znovu spusťte aplikaci ResGen
    // s parametrem /str nebo znovu sestavte projekt aplikace Visual Studio.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Vrací instanci ResourceManager uloženou v mezipaměti použitou touto třídou.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SPICA.Rendering.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Potlačí vlastnost CurrentUICulture aktuálního vlákna pro všechna
        ///   vyhledání prostředků pomocí třídy prostředků se silnými typy.
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
        ///   Vyhledá lokalizovaný řetězec podobný //SPICA auto-generated code
        /////This code was translated from a MAESTRO Vertex Shader
        /////This file was also hand modified to improve compatibility
        ///#version 330 core
        ///
        ///uniform vec4 WrldMtx[3];
        ///uniform vec4 NormMtx[3];
        ///uniform vec4 PosOffs;
        ///uniform vec4 IrScale[2];
        ///uniform vec4 TexcMap;
        ///uniform vec4 TexMtx0[3];
        ///uniform vec4 TexMtx1[3];
        ///uniform vec4 TexMtx2[2];
        ///uniform vec4 TexTran;
        ///uniform vec4 MatAmbi;
        ///uniform vec4 MatDiff;
        ///uniform vec4 HslGCol;
        ///uniform vec4 HslSCol;
        ///uniform vec4 HslSDir;
        ///uniform vec4 UnivReg[60 [zbytek řetězce byl zkrácen];.
        /// </summary>
        internal static string DefaultVertexShader {
            get {
                return ResourceManager.GetString("DefaultVertexShader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Vyhledá lokalizovaný řetězec podobný #version 150
        ///
        ///uniform sampler2D LUTs[6];
        ///
        ///uniform sampler2D Textures[3];
        ///
        ///uniform sampler2D LightDistanceLUT[3];
        ///
        ///uniform sampler2D LightAngleLUT[3];
        ///
        ///uniform samplerCube TextureCube;
        ///
        ///struct Light_t {
        ///	vec3 Position;
        ///	vec3 Direction;
        ///	vec4 Ambient;
        ///	vec4 Diffuse;
        ///	vec4 Specular0;
        ///	vec4 Specular1;
        ///	float AttScale;
        ///	float AttBias;
        ///	float AngleLUTScale;
        ///	int AngleLUTInput;
        ///	int SpotAttEnb;
        ///	int DistAttEnb;
        ///	int TwoSidedDiff;
        ///	int Directional;
        ///};
        ///
        ///uniform int LightsCount;
        ///
        ///uniform Light_t Lights[3];
        ///
        ///uniform v [zbytek řetězce byl zkrácen];.
        /// </summary>
        internal static string FragmentShaderBase {
            get {
                return ResourceManager.GetString("FragmentShaderBase", resourceCulture);
            }
        }
    }
}
