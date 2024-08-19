using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InterfaceManager : MonoBehaviour
{
    public PlayerInterface p_Interface;

    public Image Player_Image;
    public Text Player_name;
    private bool Item_Active = false;

    public GameObject Player_Interface;
    public GameObject[] Item_button = new GameObject[10];

    private void Start()
    {
        Player_Image.sprite = p_Interface.image;
        Player_name.text = p_Interface.name;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Player_Interface.activeSelf)
                Player_Interface.SetActive(false);
            else
                Player_Interface.SetActive(true);
        }
    }

    public void ActiveItem()
    {
        if (Item_Active == true)
        {
            GameObject.Find("Item").transform.Find("Image").gameObject.SetActive(false);
            Item_Active = false;
        }
        else
        {
            GameObject.Find("Item").transform.Find("Image").gameObject.SetActive(true);
            Item_Active = true;
        }
    }

    public void CloseButton()
    {
        Player_Interface.SetActive(false);
    }
}
