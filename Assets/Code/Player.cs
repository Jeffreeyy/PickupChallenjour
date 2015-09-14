using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    private int m_score = 0;
	private float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        //beweeg de speler naar rechts
        this.transform.position += Vector3.right * speed * Time.deltaTime;

		switch(m_score)
		{
		case 1:
			break;
		case 2:
			speed = .5f;
			break;
		case 3:
			this.transform.Rotate(0,0,1);
			break;
		}
    }

	public void coinsCollected(){
		m_score ++;
		Debug.Log (m_score);
	}
}
