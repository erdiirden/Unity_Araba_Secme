using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class galeri : MonoBehaviour
{
    int[] hiz = { 50, 90, 45 }; //ww,merco,reno
    int[] hizlanma = { 69, 70, 50 };
    int[] donme = { 60, 78, 68 };
    int[] genel = new int[3];
    public Text genelPuan;
    public Image[] logoImage = new Image[3];
    public Sprite[] logoSprite = new Sprite[3];
    string seciliLogo = "merco";
    string[] logolarString = { "vw", "merco", "reno" };
    public Slider[] Sliderlar = new Slider[3];
    float hiz0, hiz1, hiz2, hizlanma0, hizlanma1, hizlanma2, donme0, donme1, donme2;
    public Text[] degerYaz = new Text[3];
    public GameObject[] arabalar = new GameObject[3];
    AudioSource sesKaynak;
    public AudioClip menuSes; 
    void Start()
    {
        genel[0] = (hiz[0] + hizlanma[0] + donme[0]) / 3; 
        genel[1] = (hiz[1] + hizlanma[1] + donme[1]) / 3; 
        genel[2] = (hiz[2] + hizlanma[2] + donme[2]) / 3;
        sesKaynak = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        arabalar[0].SetActive(false);
        arabalar[2].SetActive(false);
        arabalar[1].SetActive(true);

        if (seciliLogo == "vw")
        {
            genelPuan.text = genel[0].ToString();

            hiz0 = (float)hiz[0];
            Sliderlar[0].value = hiz0 / 100;
            degerYaz[0].text = hiz[0].ToString();

            hizlanma0 = (float)hizlanma[0];
            Sliderlar[1].value = hizlanma0 / 100;
            degerYaz[1].text = hizlanma[0].ToString();

            donme0 = (float)donme[0];
            Sliderlar[2].value = donme0 / 100;
            degerYaz[2].text = donme[0].ToString();

        }
        else if (seciliLogo == "merco")
        {
            genelPuan.text = genel[1].ToString();

            hiz1 = (float)hiz[1];
            Sliderlar[0].value = hiz1 / 100;
            degerYaz[0].text = hiz[1].ToString();

            hizlanma1 = (float)hizlanma[1];
            Sliderlar[1].value = hizlanma1 / 100;
            degerYaz[1].text = hizlanma[1].ToString();

            donme1 = (float)donme[1];
            Sliderlar[2].value = donme1 / 100;
            degerYaz[2].text = donme[1].ToString();
        }
        else if (seciliLogo == "reno")
        {
            genelPuan.text=genel[2].ToString();

            hiz2 = (float)hiz[2];
            Sliderlar[0].value = hiz2 / 100;
            degerYaz[0].text = hiz[2].ToString();

            hizlanma2 = (float)hizlanma[2];
            Sliderlar[1].value = hizlanma2 / 100;
            degerYaz[1].text = hizlanma[2].ToString();

            donme2 = (float)donme[2];
            Sliderlar[2].value = donme2 / 100;
            degerYaz[2].text = donme[2].ToString();

        }
    }
    public void solOK()
    {
        logoImage[0].sprite = logoSprite[1];
        logoImage[1].sprite = logoSprite[2];
        logoImage[2].sprite = logoSprite[0];
        Sprite temp = logoSprite[0];
        logoSprite[0] = logoSprite[1];
        logoSprite[1] = logoSprite[2];
        logoSprite[2] = temp;

        seciliLogo = logolarString[2];
        string temp2 =logolarString[0];
        logolarString[0] = logolarString[1];
        logolarString[1] = logolarString[2];
        logolarString[2] = temp2;

        GameObject temp3 = arabalar[0];
        arabalar[0] = arabalar[1];
        arabalar[1] = arabalar[2];
        arabalar[2] = temp3;

        sesKaynak.PlayOneShot(menuSes);
    }
    public void sagOK()
    {
        logoImage[2].sprite = logoSprite[1];
        logoImage[1].sprite = logoSprite[0];
        logoImage[0].sprite = logoSprite[2];
        Sprite temp = logoSprite[2];
        logoSprite[2] = logoSprite[1];
        logoSprite[1] = logoSprite[0];
        logoSprite[0] = temp;

        seciliLogo = logolarString[0];
        string temp2 = logolarString[2];
        logolarString[2] = logolarString[1];
        logolarString[1] = logolarString[0];
        logolarString[0] = temp2;

        GameObject temp3 = arabalar[2];
        arabalar[2] = arabalar[1];
        arabalar[1] = arabalar[0];
        arabalar[0] = temp3;

        sesKaynak.PlayOneShot(menuSes);
    }
}
