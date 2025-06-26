using AudioConductor.Sample;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMSource : MonoBehaviour
{
    public string Name;//需要播放的BGM名称

    // Start is called before the first frame update
    void Start()
    {
        SampleScene.Instance.SelectIndex(0); //选择播放轨道0，轨道0是BGM播放轨道
        SampleScene.Instance.Play(Name);
        SampleScene.Instance.SelectIndex(1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
