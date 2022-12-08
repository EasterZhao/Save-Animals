using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//https://www.youtube.com/watch?v=9a6GyAbhLUk
public class AutoScroll : MonoBehaviour
{
    float speed = 40.0f;
    float boundaryTextEnd = 1036.0f;

    RectTransform myTransform;
    [SerializeField]
    TextMeshProUGUI mainText;

    public GameObject exitPanel;
    void Start()
    {
        myTransform = gameObject.GetComponent<RectTransform>();
        StartCoroutine(AutoScrollText());
    }

    IEnumerator AutoScrollText()
    {
        while(myTransform.localPosition.y< boundaryTextEnd)
        {
            myTransform.Translate(Vector3.up * speed * Time.deltaTime);
            yield return null;

        }
        if(myTransform.localPosition.y >= boundaryTextEnd)
        {
             exitPanel.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
