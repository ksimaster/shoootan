using System.Collections;
using UnityEngine;
public class Healthspawner : MonoBehaviour
{
    public Animator healthgainUI;
    public GameObject healthboxREF;
    public float HealthSpawnTime = 5f;
    IEnumerator SpawnTheHealthBox()
    {
        yield return new WaitForSeconds(HealthSpawnTime);
        Debug.Log("Spawning Health Box! at: " + transform.position);
        GameObject a = Instantiate(healthboxREF) as GameObject;
        a.transform.position = transform.position;
        yield break;
    }
    public void SpawnWaitHealth()
    {

        /*Collider[] intersecting = Physics.OverlapSphere(transform.position, 0.01f);
        if (intersecting.Length == 0)
        {
            Debug.Log("HEALTH ISNT Here ");
            StartCoroutine(SpawnTheHealthBox());
        }
        else if(intersecting.Length == 1)
            Debug.Log("HEALTH IS already Here at "  + transform.position);*/
        //healthgainUI.Play("Base Layer.healthGain", 0, 0f);
        healthgainUI.SetTrigger("healthgained");
        StartCoroutine(SpawnTheHealthBox());
        
    }
}
