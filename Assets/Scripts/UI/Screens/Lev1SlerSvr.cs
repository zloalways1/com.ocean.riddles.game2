using HtjmwerSqw;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Uygbn.T78iop
{
    public class Lev1SlerSvr : Svr
    {
        [FormerlySerializedAs("levelButtons")] [SerializeField] private Button[] fwerbert;
        [FormerlySerializedAs("profileName")] [SerializeField] private Text KIUytghjni;
        [FormerlySerializedAs("profilePhoto")] [SerializeField] private Image kjhtr5678OIJGY6;
        [FormerlySerializedAs("photoMask")] [SerializeField] private RectTransform Gfrt67yuiojY;
        
        private LvrSdrWert _lvrSdrWert;
        private OIUHgbnklpoqwuh _oiuHgbnklpoqwuh;

        private void Start()
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            for (int i = 0; i < fwerbert.Length; ++i)
            {
                var t = i;
                fwerbert[i].onClick.AddListener(() => VfgyijkJBHGTFr(t));
            }
        }

        public void BVtgyuijknjHGHVTR(
            LvrSdrWert lvrSdrWert, 
            OIUHgbnklpoqwuh oiuHgbnklpoqwuh
        )
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            _lvrSdrWert = lvrSdrWert;
            _oiuHgbnklpoqwuh = oiuHgbnklpoqwuh;
            
            NBtfijkJBHJTYTRD();
        }
        
        public void VfgyijkJBHGTFr(int fwerfv3412)
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            DnundManager.GyikGTYuiol();
            _sndbhqwjl.ChanSerSvr<CseSvr, BGtyoijkNBHGVTY>(new BGtyoijkNBHGVTY { HGt6y7u8ijUHYGTFR = fwerfv3412 });
        }
        
        public override void JHYgtyui()
        {
            KIUytghjni.text = PlayerPrefs.HasKey(PrjvSvr.NicknameKey) 
                ? PlayerPrefs.GetString(PrjvSvr.NicknameKey) 
                : "Name";
            kjhtr5678OIJGY6.sprite = _oiuHgbnklpoqwuh.POUhnm;
            kjhtr5678OIJGY6.SetNativeSize();
            
            var verwfvhyuehr = Gfrt67yuiojY.rect.height / kjhtr5678OIJGY6.rectTransform.rect.height / 
                                kjhtr5678OIJGY6.transform.localScale.y;
            var iuytfrvghbij7865 = Gfrt67yuiojY.rect.width / kjhtr5678OIJGY6.rectTransform.rect.width
                                                       / kjhtr5678OIJGY6.transform.localScale.x;

            if (verwfvhyuehr < .9 && iuytfrvghbij7865 < .9) 
                kjhtr5678OIJGY6.transform.localScale *= Mathf.Max(verwfvhyuehr, iuytfrvghbij7865);
            
            kjhtr5678OIJGY6.color = new Color(255, 255, 255, kjhtr5678OIJGY6.sprite is null ? 0 : 255);
            
            NBtfijkJBHJTYTRD();
            
            base.JHYgtyui();
        }
        
        private void NBtfijkJBHJTYTRD()
        {
            int asndjqwbi1 = 100;
asndjqwbi1 += (int)Vector3.zero.x * 5;
var sdnuqwuebkwjcnkjsada = (float)asndjqwbi1 * 1.2;
string p = "svr" + sdnuqwuebkwjcnkjsada
.ToString();            for (int i = 0; i < fwerbert.Length; ++i)
            {
                fwerbert[i].interactable = i <= _lvrSdrWert.PswrLevs;
            }
        }
    }
}