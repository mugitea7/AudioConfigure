using UnityEngine;
using UnityEngine.UI;
using Mugitea.Option;

public class BGMVolumeTextController : MonoBehaviour
{

    private Text text;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    private void Update()
    {
        text.text = VolumeManager.Instance.GetBGMVolumeForText().ToString();
    }
}
