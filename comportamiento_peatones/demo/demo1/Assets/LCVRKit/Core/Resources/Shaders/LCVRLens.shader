// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

//
// LC VR Kit
//
// Copyright (c) 2015 Laurel Code Inc.
// All rights reserved.
//
// Contact: Laurel Code Inc. (support@laurel-code.com)
//


Shader "LCVRKit/LCVRLens" {
	Properties {
		_MainTex("Base"      , 2D) = "white" {}
		_DistMap("Distortion", 2D) = "black" {}
	}

	SubShader {
	  Tags { "RenderType"="Opaque" }
	  Pass
	  {

	  Lighting Off
	  ZWrite   Off 
	  ZTest    Always
	  Cull     Off
	  Fog      { Mode Off }

CGPROGRAM
#pragma vertex   vert
#pragma fragment frag

struct appdata{
	float4 vertex   : POSITION ;
	float2 texcoord : TEXCOORD0;
};

struct v2f{
	float4 pos : SV_POSITION;
	float2 uv  : TEXCOORD0  ;
};

sampler2D _MainTex;
sampler2D _DistMap;

fixed4 frag(v2f i) : COLOR
{
	float4 dist = tex2D(_DistMap, i.uv);

	float  s    = dist.z * 2.0f - 1.0f;
	float  d    = dist.x * pow(2, dist.y * 255.0f - 128.0f) * s;

	float2 p = i.uv * 2.0f - 1.0f;

	return tex2D(_MainTex, i.uv + p / (1.0f + d) - p) * dist.w;
}

v2f vert(appdata v)
{
	v2f o;
	o.pos = UnityObjectToClipPos(v.vertex);
	o.uv  = v.texcoord;
	return o;
}
ENDCG
    }
	}

	Fallback Off
}
