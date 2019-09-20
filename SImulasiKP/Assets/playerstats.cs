using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerstats : MonoBehaviour
{
    // Start is called before the first frame update

    public float focus;
    public float energy;
    public float social;
    public float confidence;
    public float intelligence;
    public float dilligence;

    void Start()
    {
        focus = 100;
        energy = 100;
        social = 100;
        confidence = 100;
        intelligence = 100;
        dilligence = 100;
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float getFocus()
    {
        return focus;
    }
    public float getEnergy()
    {
        return energy;
    }
    public float getSocial()
    {
        return social;
    }
    public float getConfidence()
    {
        return confidence;
    }
    public float getIntelligence()
    {
        return intelligence;
    }
    public float getDilligence()
    {
        return dilligence;
    }
    public void setFocus(float focus)
    {
        this.focus = focus;
    }
    public void setEnergy(float energy)
    {
        this.energy = energy;
    }
    public void setSocial(float social)
    {
        this.social = social;
    }
    public void setConfidence(float confidence)
    {
        this.confidence = confidence;
    }
    public void setIntelligence(float intelligence)
    {
        this.intelligence = intelligence;
    }
    public void setDilligence(float dilligence)
    {
        this.dilligence = dilligence;
    }

}
