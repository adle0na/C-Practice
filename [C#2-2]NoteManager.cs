using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
	public int bpm = 0;
	double currentTime = 0d;

	[SerializeField] Transform tfNoteSpawner = null;
	[SerializeField] GameObject goNote = null;

	TimingManager theTimingManager;
	EffectManager theEffectManager;

	// Start is called before the first frame update
	void Start()
	{
		theEffectManager = FindObjectOfType<EffectManager>();
		theTimingManager = GetComponent<TimingManager>();
	}
	void Update()
	{
		currentTime += Time.deltaTime;

		if(currentTime >= 60d / bpm)
		{
			GameObject t_note = Instantiate(goNote, tfNoteSpawner.position, Quaternion.identity);
			t_note.transform.SetParent(this.transform);
			theTimingManager.boxNoteList.Add(t_note);
			currentTime -= 60d / bpm;
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if(collision.CompareTag("Notes"))
		{
			if(collision.GetComponent<Note>().GetNoteFlag())
				theEffectManager.JudgementEffect(4);

			theTimingManager.boxNoteList.Remove(collision.gameObject);
			Destroy(collision.gameObject);
		}
	}
}
