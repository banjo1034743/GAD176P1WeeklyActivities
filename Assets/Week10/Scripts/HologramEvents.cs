using UnityEngine;

namespace GAD176.P2.ClassActivities.Week10.Holograms
{
    public static class HologramEvents
    {
        //public UnityEvent OnSpacebarPressed = new UnityEvent(); // often empty for events

        public delegate void VoidDelegate();

        public static VoidDelegate onSpacebarPressed;
        public static VoidDelegate onZButtonPressed;
    }
}
