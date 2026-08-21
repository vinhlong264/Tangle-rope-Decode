Shader "Shader Graphs/RopeShaderMultiColor" {
	Properties {
		_NormalMapping ("NormalMapping", 2D) = "white" {}
		[HDR] _ShadowColor ("ShadowColor", Vector) = (0,0,0,0)
		[HDR] _HightlightColor ("HightlightColor", Vector) = (0,0,0,0)
		_NormalMapStrength ("NormalMapStrength", Float) = 0
		_Smoothness ("Smoothness", Float) = 0
		_Metallic ("Metallic", Float) = 0
		_Color ("Color", Vector) = (1,0.9137255,0.2392157,1)
		_Color2 ("Color2", Vector) = (1,0.1098039,0.1098039,0)
		_Color2Remap ("Color2Remap", Vector) = (0,0.5,0,0)
		_Color3 ("Color3", Vector) = (0,0.4,0.7176471,0)
		_Color3Remap ("Color3Remap", Vector) = (0.25,0.5,0,0)
		_Color4 ("Color4", Vector) = (0,0.9058824,0.972549,0)
		_Color4Remap ("Color4Remap", Vector) = (0.5,1,0,0)
		_Color5 ("Color5", Vector) = (1,0.003921569,0.9372549,0)
		_Color5Remap ("Color5Remap", Vector) = (0.75,1,0,0)
		_Color6 ("Color6", Vector) = (0,0,0,0)
		_Color6Remap ("Color6Remap", Vector) = (0.48,0.52,0,0)
		[HideInInspector] _BUILTIN_Surface ("Float", Float) = 0
		[HideInInspector] _BUILTIN_Blend ("Float", Float) = 0
		[HideInInspector] _BUILTIN_AlphaClip ("Float", Float) = 1
		[HideInInspector] _BUILTIN_SrcBlend ("Float", Float) = 1
		[HideInInspector] _BUILTIN_DstBlend ("Float", Float) = 0
		[HideInInspector] _BUILTIN_ZWrite ("Float", Float) = 1
		[HideInInspector] _BUILTIN_ZWriteControl ("Float", Float) = 0
		[HideInInspector] _BUILTIN_ZTest ("Float", Float) = 4
		[HideInInspector] _BUILTIN_CullMode ("Float", Float) = 2
		[HideInInspector] _BUILTIN_QueueOffset ("Float", Float) = 0
		[HideInInspector] _BUILTIN_QueueControl ("Float", Float) = -1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 _Color;

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return _Color; // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Hidden/Shader Graph/FallbackError"
	//CustomEditor "UnityEditor.ShaderGraph.GenericShaderGraphMaterialGUI"
}