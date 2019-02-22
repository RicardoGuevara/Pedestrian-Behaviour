//
// LC VR Kit Ex
//
// Copyright (c) 2015 Laurel Code Inc.
// All rights reserved.
//
// Contact: Laurel Code Inc. (support@laurel-code.com)
//


using UnityEngine;


public class LCVRAutoDestroy : MonoBehaviour
{
	[SerializeField] private float lifeTime = 5.0f;
	
	private void Start(){ Destroy(gameObject, lifeTime); }
}
