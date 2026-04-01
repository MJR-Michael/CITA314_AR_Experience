using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets
{
    public class ColorChanger : MonoBehaviour
    {
        [SerializeField] List<Material> setMaterial = new List<Material>();

        public void ChangeObjectMaterial(GameObject setobject)
        {
            Transform child = setobject.transform.Find("Visuals");
            child.GetComponent<MeshRenderer>().material = setMaterial[Random.Range(0,4)];
        }
    }
}