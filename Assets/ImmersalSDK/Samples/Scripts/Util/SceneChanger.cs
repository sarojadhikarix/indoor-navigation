using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneChanger : MonoBehaviour
{
    public TMP_Dropdown BuildingDropdown;
    public TMP_Dropdown FloorDropdown;

    public void ChangeScene() 
    { 
        string BuildingNumber = BuildingDropdown.value.ToString();
        string FloorNumber = FloorDropdown.value.ToString();

        if(BuildingNumber.Equals("0") && FloorNumber.Equals("0"))
        {
             SceneManager.LoadScene("Building0801");
        }
         
    } 

    public void HomeScene() 
    { 
             SceneManager.LoadScene("Welcome");
    } 
}
