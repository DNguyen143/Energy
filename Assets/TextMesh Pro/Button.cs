using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int mod;
    [SerializeField] NewBehaviourScript butt;
    [SerializeField] TMP_Text text;
    [SerializeField] TMP_Text textrand;
    public int Num =1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void OnPress()
    {
        butt.E += mod;
        if (butt.E > 10) butt.E = 10;
        if (butt.E < 0) butt.E = 0;
        text.text = butt.E.ToString();
    }
    public void onRandom()
    {
        Num = Random.Range(1, 6);
        textrand.text = Num.ToString();
    }
}
