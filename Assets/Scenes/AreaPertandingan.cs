using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AreaPertandingan : MonoBehaviour
{
    [Header("Sistem Penghubung Skor")]
    public KendaliPemain pemain1, pemain2;
    public Text teksPembataSkor;

    [Header("Sistem Skoring")]
    public string skorPemain1, skorPemain2;
    public string bataSkor;

    [Header("Sistem Pemenang Skor")]
    public GameObject pemenang1, pemenang2, mainMenu, tombolSelesai, pong;

    void Update()
    {
        skorPemain1 = pemain1.skorTextPemain1.text;
        if(skorPemain1 == bataSkor)
        {
            mainMenu.SetActive(true);
            pemenang1.SetActive(true);
            tombolSelesai.SetActive(true);
            Destroy(pong);
        }

        skorPemain2 = pemain2.skorTextPemain2.text;
        if(skorPemain2 == bataSkor)
        {
            mainMenu.SetActive(true);
            pemenang2.SetActive(true);
            tombolSelesai.SetActive (true);
            Destroy (pong);
        }

        bataSkor = teksPembataSkor.text;
    }

    public void mainLagi()
    {
        SceneManager.LoadScene(0);
    }
}