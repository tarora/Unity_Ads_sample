using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class AdvertisementTest : MonoBehaviour {

    private string androidGameID = "54884";

    void Awake() {
        if (Advertisement.isSupported) {
            Advertisement.Initialize(androidGameID, true);
        } else {
            Debug.Log("Platform not supported");
        }
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 150, 50), Advertisement.IsReady() ? "Show Ad" : "Waiting..."))
        {
            // Show with default zone, pause engine and print result to debug log
            Advertisement.Show(null, new ShowOptions
            {
                resultCallback = result =>
                {
                    Debug.Log(result.ToString());
                }
            });
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
