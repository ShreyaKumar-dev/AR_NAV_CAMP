using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class SimpleBarcodeScanner : MonoBehaviour
{
    public TMPro.TextMeshProUGUI barcodeAsText;
    BarcodeBehaviour mBarcodeBehaviour;

    void Start()
    {
        mBarcodeBehaviour = GetComponent<BarcodeBehaviour>();
    }

    // Update is called once per frame
    // Update is called once per frame
    void Update()
    {
        if (mBarcodeBehaviour != null && mBarcodeBehaviour.InstanceData != null)
        {
            string scannedBarcode = mBarcodeBehaviour.InstanceData.Text;
            barcodeAsText.text = scannedBarcode;

            // Check if the scanned barcode is correct
            if (IsCorrectBarcode(scannedBarcode))
            {
                // Load the next scene
                SceneManager.LoadScene("CollegeNav"); // Use the name of the next scene
            }
        }
        else
        {
            barcodeAsText.text = "Error!";
        }
    }

    bool IsCorrectBarcode(string barcode)
    {
        // Define the expected correct barcode value here
        string expectedBarcode = "Start";

        // Compare the scanned barcode with the expected value
        return barcode == expectedBarcode;
    }

}
