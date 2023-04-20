using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisanu : MonoBehaviour {
    public GameObject beanImg;
    public GameObject lacisImg;
    public GameObject tanteImg;
    public GameObject masinaImg;
    public GameObject paKreisiPoga;
    public GameObject paLabiPoga;
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public void beanAttelosana(bool vertiba) {
        beanImg.SetActive(vertiba);
        paKreisiPoga.GetComponent<Toggle>().interactable = vertiba;
        paLabiPoga.GetComponent<Toggle>().interactable = vertiba;
    }

    public void lacisaAttelosana(bool vertiba)
    {
        lacisImg.SetActive(vertiba);
    }
    public void tantesAttelosana(bool vertiba)
    {
        tanteImg.SetActive(vertiba);
    }
    public void masinasAttelosana(bool vertiba)
    {
        masinaImg.SetActive(vertiba);
    }

    public void paKreisiBeans() {
        beanImg.transform.localScale = new Vector2(2, 2);}
    public void paLabiBeans() {
        beanImg.transform.localScale = new Vector2(-2, 2);}

    public void izkritosais(int skaitlis) {
        if (skaitlis == 0)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
        else if (skaitlis == 1)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
        else if (skaitlis == 2)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[2];
        else
            Debug.Log("nav piesaistits attels");
    }
}
