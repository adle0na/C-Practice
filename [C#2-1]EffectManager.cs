using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
	// Start is called before the first frame update
	[SerializeField] Animator noteHitAnimator = null;
	string hit = "Hit";

	[SerializeField] Animator judgementAnimator = null;
	[SerializeField] UnityEngine.UI.Image judgementImage = null;
	[SerializeField] Sprite[] judgementSprite = null;

	public void JudgementEffect(int p_num)
	{
		judgementImage.sprite = judgementSprite[p_num];
		judgementAnimator.SetTrigger(hit);
	}

	public void NoteHitEffect()
	{
		noteHitAnimator.SetTrigger(hit);
	}

}
