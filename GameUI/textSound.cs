
using UnityEngine;
using UnityEngine.UI;

public class textSound : MonoBehaviour
{
    [SerializeField] private string volume;
    [SerializeField] private string textIntro;
    private Text txt;

    private void Awake()
    {
        txt = GetComponent<Text>();
    }
    private void Update()
    {
        UpdateVolume();
    }
    private void UpdateVolume()
    {
        float volumeValue = 0.2f ;
        txt.text = textIntro + volumeValue.ToString();
    }

}
