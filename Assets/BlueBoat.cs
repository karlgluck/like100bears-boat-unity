// This is free and unencumbered software released into the public domain.
// 
// Anyone is free to copy, modify, publish, use, compile, sell, or
// distribute this software, either in source code form or as a compiled
// binary, for any purpose, commercial or non-commercial, and by any
// means.
// 
// In jurisdictions that recognize copyright laws, the author or authors
// of this software dedicate any and all copyright interest in the
// software to the public domain. We make this dedication for the benefit
// of the public at large and to the detriment of our heirs and
// successors. We intend this dedication to be an overt act of
// relinquishment in perpetuity of all present and future rights to this
// software under copyright law.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR
// OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
// 
// For more information, please refer to <http://unlicense.org/>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BlueBoatLayerStackMethod
{
    SortingOrder,
    ZDepth,
}

[ExecuteInEditMode]
public class BlueBoat : MonoBehaviour
{
#region Settings
[Range (0.01f, 10f)]
public float LayerStackHeight = 4f;
public BlueBoatLayerStackMethod LayerStackMethod;
#endregion


#region References
public SpriteRenderer[] LayerStack;
#endregion

#region Runtime data
#endregion

void Update ()
    {
    if (this.LayerStack == null)
        {
        return;
        }
    for (int i = 0; i < this.LayerStack.Length; ++i)
        {
        if (this.LayerStackMethod == BlueBoatLayerStackMethod.SortingOrder)
            {
            this.LayerStack[i].sortingOrder = i;
            }
        this.LayerStack[i].transform.position = new Vector3 (
                this.transform.position.x,
                this.transform.position.y + i * this.LayerStackHeight / this.LayerStack.Length,
                this.transform.position.z +
                        ((this.LayerStackMethod == BlueBoatLayerStackMethod.ZDepth) ? -i : 0)
                );
        }
    }

}
