using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/*

Clickable mesh checklist:

Added EventSystem game object to scene (Create -> UI -> Event System)

Camera has a Physics Raycaster (Select Main Camera, Add Component -> Event -> Physics Raycaster)

Selectable object is a MonoBehavior-derived class that implements IPointerClickHandler, IPointerDownHandler, and IPointerUpHandler (see accepted answer).

Selectable game object includes selectable object MonoBehavior script.

Selectable game object includes a collider (box, mesh, or any other collider type).

Check Raycaster Event Mask vs. game object's Layer mask

Verify no collider (possibly without a mesh) is obscuring the selectable game object.

If collider is a trigger, verify that Queries Hit Triggers is enabled in Physics settings.
*/


public abstract class Animal : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // abstract class that must be defined in child
    protected abstract void Pet();

    // non overridable
    protected void Drink() {
        Debug.Log("Slurps");
    }

    // Virtual allows overriding
    protected virtual void Eat() {
        Debug.Log("Yum Yum");
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        Drink();
        Eat();
        Pet();
    }


}
