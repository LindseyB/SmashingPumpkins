using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Smash : MonoBehaviour {
    [SerializeField] private Text scoreText;

    private bool smashed = false;
    private static int score = 0;

	void Start () {
        scoreText.text = score.ToString();
    }
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (smashed) {
                Application.LoadLevel(0);
                smashed = false;
            } else {
                smashed = true;
                foreach (Rigidbody rigidbody in gameObject.GetComponentsInChildren<Rigidbody>()) {
                    rigidbody.isKinematic = false;
                }
                score++;
                scoreText.text = score.ToString();
            }
        }
	}
}
