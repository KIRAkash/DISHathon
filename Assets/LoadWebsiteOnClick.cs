using System.Collections;
using UnityEngine;

public class LoadWebsiteOnClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	public void dst () {
		Application.OpenURL("http://www.dst.gov.in");
	}
    public void ggov()
    {
        Application.OpenURL("http://www.gandhi.gov.in");
    }
    public void gorg()
    {
        Application.OpenURL("http://www.mkgandhi.org");
    }
    public void wiki()
    {
        Application.OpenURL("https://en.wikipedia.org/wiki/Mahatma_Gandhi#p-search");
    }
    public void gserve()
    {
        Application.OpenURL("http://www.gandhiserve.org");
    }
    void Update(){
	}
}
