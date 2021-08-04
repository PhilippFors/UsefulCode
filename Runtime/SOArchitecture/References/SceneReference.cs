using UsefulCode.SOArchitecture.Utility;

namespace UsefulCode.SOArchitecture
{
    [System.Serializable]
    public class SceneReference : BaseReference<SceneInfo, SceneVariable>
    {
        public SceneReference()
        {
        }

        public SceneReference(SceneInfo value) : base(value)
        {
        }
    }
}