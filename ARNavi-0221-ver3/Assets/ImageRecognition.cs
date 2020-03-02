using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZXing;
using GoogleARCore;

public class ImageRecognition : MonoBehaviour
{
    public bool searchingForMarker;
    public Transform calibrationLocations;
    public GameObject person;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public bool StartPosition(WebCamTexture wt)
    {
        bool succeeded = false;
        try
        {
            IBarcodeReader barcodeReader = new BarcodeReader();
            // decode the current frame
            var result = barcodeReader.Decode(wt.GetPixels32(), wt.width, wt.height);
            if (result != null)
            {
                Relocate(result.Text);
                succeeded = true;
            }
        }
        catch { Debug.LogWarning("Failed"); }
        return succeeded;
    }
    // move to person indicator to the new spot
    private void Relocate(string text)
    {
        text = text.Trim(); //remove spaces
                            //find the correct location scanned and move the person to its position
        foreach (Transform child in calibrationLocations.transform)
        {
            if (child.name.Equals(text))
            {
                person.transform.position = child.position;
                break;
            }
        }
        searchingForMarker = false;
    }
}
