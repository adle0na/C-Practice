using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
	public int bpm = 0;
	double currentTime = 0d;


	[SerializeField] Transform tfNoteSpawner = null;

	TimingManager theTimingManager;
	EffectManager theEffectManager;
	ComboManager theComboManager;

	// Start is called before the first frame update
	void Start()
	{
		theEffectManager = FindObjectOfType<EffectManager>();
		theTimingManager = GetComponent<TimingManager>();
		theComboManager = FindObjectOfType<ComboManager>();
	}

	void Update()
	{
		if (GameManager.instance.isStartGame)
        {
			currentTime += Time.deltaTime;

			if (currentTime >= 60d / bpm)
			{
				GameObject t_note = ObjectPool.instance.noteQueue.Dequeue();
				t_note.transform.position = tfNoteSpawner.position;
				t_note.SetActive(true);
				theTimingManager.boxNoteList.Add(t_note);
				currentTime -= 60d / bpm;
			}
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if(collision.CompareTag("Notes"))
		{
			if (collision.GetComponent<Note>().GetNoteFlag())
			{
				theTimingManager.MissRecord();
				theEffectManager.JudgementEffect(4);
				theComboManager.ResetCombo();
			}

			theTimingManager.boxNoteList.Remove(collision.gameObject);
			ObjectPool.instance.noteQueue.Enqueue(collision.gameObject);
			collision.gameObject.SetActive(false);
			//Destroy(collision.gameObject);
		}
	}

	public void RemoveNote()
    {
		GameManager.instance.isStartGame = false;

		for(int i = 0; i < theTimingManager.boxNoteList.Count; i++)
        {
			theTimingManager.boxNoteList[i].SetActive(false);
			ObjectPool.instance.noteQueue.Enqueue(theTimingManager.boxNoteList[i]);
        }
    }
}
