using System.Collections;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int maxHits;
	public int timesHit;
	
    void Start()
    {
        timesHit = 0;
    }

    void Update()
    {
        
    }
	
	void OnCollisionEnter2D(Collision2D col)
	{
		print ("HIT!");
		timesHit++;
		
		if (timesHit == maxHits)
		{
			print ("Destroyed");
			Destroy (gameObject);
		}
	}
}
