//
// LC VR Kit
//
// Copyright (c) 2015 Laurel Code Inc.
// All rights reserved.
//
// Contact: Laurel Code Inc. (support@laurel-code.com)
//


using UnityEngine;


public class LCVRSwapHMD : MonoBehaviour
{
	[SerializeField] private LCVRPopupLabel label;

	private int hmdIndex = 0; // 0:hacosco dx 1:google cardboard 2:hacosco(single view)

	private void setHMDType(Camera eye, LCVRLens.HMD_TYPE hmdType){
		LCVRLens lens = eye.gameObject.GetComponent<LCVRLens>();
		if (lens != null) lens.HMDType = hmdType;
	}

	private void setViewModeAndHMDType(LCVRHead.VIEW_MODE viewMode, LCVRLens.HMD_TYPE hmdType){
		foreach (LCVRHead head in LCVR.Instance.Heads){
			head.ViewMode = viewMode;

			if (head.  LeftEye) setHMDType(head.  LeftEye, hmdType);
			if (head.CenterEye) setHMDType(head.CenterEye, hmdType);
			if (head. RightEye) setHMDType(head. RightEye, hmdType);
		}
	}

	private void updateHMD(){
		LCVRHead.VIEW_MODE viewMode = LCVRHead.VIEW_MODE.SIDE_BY_SIDE;
		LCVRLens.HMD_TYPE  hmdType  = LCVRLens.HMD_TYPE.HACOSCO_DX;

		string  name = null;

		switch (hmdIndex){
		case 0: name = "HACOSCO DX"      ; break;
		case 1: name = "Google Cardboard"; hmdType = LCVRLens.HMD_TYPE.GOOGLE_CARDBOARD; break;
		case 2: name = "HACOSCO (Single)"; hmdType = LCVRLens.HMD_TYPE.HACOSCO         ; viewMode = LCVRHead.VIEW_MODE.SINGLE; break;
		}

		setViewModeAndHMDType(viewMode, hmdType);

		label.Show(name);
	}

	public void OnClicked(){
		hmdIndex = (hmdIndex + 1) % 3;
		updateHMD();
	}

	private void Start(){ updateHMD(); }
}
