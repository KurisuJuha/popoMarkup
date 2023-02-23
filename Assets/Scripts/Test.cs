using UnityEngine;
using JuhaKurisu.PopoTools.Markup;

public class Test : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("aiueo" + Style.Color(Color.red));
        Debug.Log("hoge" + Style.Bold());
        Debug.Log("kaki" + Style.Color(Color.blue) + ("kukeko" + Style.Color(Color.yellow) + Style.bold));
        Debug.Log("piza" + Style.italic);
        Debug.Log(Style.italic["susi"] + Style.bold["tabetai"]);
    }
}