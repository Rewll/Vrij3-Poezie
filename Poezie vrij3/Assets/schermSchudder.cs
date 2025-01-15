using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class schermSchudder : MonoBehaviour
{
    public CinemachineVirtualCamera cinVirtCam;
    CinemachineBasicMultiChannelPerlin perlin;
    public float schudLengte;
    public float schudHardheid;

    private void Start()
    {
        perlin = cinVirtCam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        perlin.m_AmplitudeGain = 0;
    }

    public void SchermSchudden()
    {
        perlin.m_AmplitudeGain =+ 1f;
        //StartCoroutine(schermSchudRoutine());
    }

    public void schermSchudStop()
    {
        perlin.m_AmplitudeGain = 0;
    }

    IEnumerator schermSchudRoutine()
    {
        perlin.m_FrequencyGain = schudHardheid;
        yield return new WaitForSeconds(schudLengte);
        perlin.m_FrequencyGain = 0;
    }
}
