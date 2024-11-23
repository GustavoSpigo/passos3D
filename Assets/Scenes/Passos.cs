using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passos : MonoBehaviour
{
    [SerializeField]
    private AudioSource m_AudioSource;
    [SerializeField]
    private AudioSource maquina;
    
    public void Passo()
    { 
        m_AudioSource.volume = Random.Range(0.4f, 0.6f);
        m_AudioSource.pitch = Random.Range(0.8f, 1.2f);
        m_AudioSource.Play(); 
    }
    public void PassoAgachado()
    {
        m_AudioSource.volume = Random.Range(0.1f, 0.3f);
        m_AudioSource.pitch = Random.Range(0.8f, 1.2f);
        m_AudioSource.Play();
    }

    public void Update()
    {
        maquina.volume = (Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x / 20) + 0.5f);
    }
}
