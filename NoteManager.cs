using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
	public int bpm = 0;
	double currentTime = 0d;

	[SerializeField] Transform tfNoteSpawner = null;
	[SerializeField] GameObject goNote = null;

	// Start is called before the first frame update
	void Update()
	{
		currentTime += Time.deltaTime;

		if(currentTime >= 60d / bpm)
		{
			GameObject t_note = Instantiate(goNote, tfNoteSpawner.position, Quaternion.identity);
			t_note.transform.SetParent(this.transform);
			currentTime -= 60d / bpm;
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if(collision.CompareTag("Notes"))
		{
			Destroy(collision.gameObject);
		}
	}
}
