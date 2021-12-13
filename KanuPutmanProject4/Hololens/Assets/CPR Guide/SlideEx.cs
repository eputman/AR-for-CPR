using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SlideEx : MonoBehaviour
{
    public GameObject[] slides;
    public TextMesh text;
    public AudioSource BPM;
    int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        turnOff();
        text.text = "Start";
        slides[0].SetActive(true);
    }

    void turnOff()
    { 
        for (int i = 0; i < slides.Length; i++)
        {
            slides[i].SetActive(false);

            if (index == 8)
            {
                index = 0;
                slides[index].SetActive(true);

            }
            // Control of heart beat audio
            if (index == 5 || index == 7)
            {
                BPM.Play();
            }
            if(index == 6 || index == 0)
            {
                BPM.Stop();
            }

        }
    }


    public void nextSlide()
    {        
        turnOff();
        text.text = "Proceed";
        Debug.Log("Slide = " + index);
        slides[index].SetActive(true);
        index++;
        Debug.Log("Next slide = " + index);      
    }

}
