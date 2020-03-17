using UnityEngine;
using UnityEngine.UI;
using Mugitea.Option;

public class SEVolumeTextController : MonoBehaviour
{

    private Text text;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    private void Update()
    {
        text.text = VolumeManager.Instance.GetSEVolumeForText().ToString();
    }
}
