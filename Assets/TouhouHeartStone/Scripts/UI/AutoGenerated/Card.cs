//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UI
{
    using System;
    using UnityEngine;
    using UnityEngine.UI;
    using BJSYGameCore.UI;
    
    public partial class Card : UIObject
    {
        protected override void Awake()
        {
            base.Awake();
            this.autoBind();
            this.onAwake();
        }
        public void autoBind()
        {
            this._CardBackImage = this.transform.Find("CardBack").GetComponent<Image>();
            this._Image_1 = this.transform.Find("CardBack").Find("Image_1").GetComponent<Image>();
            this._Image_2 = this.transform.Find("CardBack").Find("Image_2").GetComponent<Image>();
            this._ShadowImage = this.transform.Find("CardFace").Find("Shadow").GetComponent<Image>();
            this._BackgroundImage = this.transform.Find("CardFace").Find("Background").GetComponent<Image>();
            this._Mask = this.transform.Find("CardFace").Find("Mask").GetComponent<Mask>();
            this._Image = this.transform.Find("CardFace").Find("Mask").Find("Image").GetComponent<Image>();
            this._NameShadowImage = this.transform.Find("CardFace").Find("Mask").Find("NameShadow").GetComponent<Image>();
            this._NameText = this.transform.Find("CardFace").Find("Mask").Find("NameShadow").Find("NameText").GetComponent<Text>();
            this._DescText = this.transform.Find("CardFace").Find("Mask").Find("DescText").GetComponent<Text>();
            this._BorderImage = this.transform.Find("CardFace").Find("Border").GetComponent<Image>();
            this._CardFace_Image = this.transform.Find("CardFace").Find("Image").GetComponent<Image>();
            this._CostImage = this.transform.Find("CardFace").Find("CostImage").GetComponent<Image>();
            this._CostPropNumber = this.transform.Find("CardFace").Find("Cost").GetComponent<PropNumber>();
            this._AttackImage = this.transform.Find("CardFace").Find("AttackImage").GetComponent<Image>();
            this._AttackPropNumber = this.transform.Find("CardFace").Find("Attack").GetComponent<PropNumber>();
            this._LifeImage = this.transform.Find("CardFace").Find("LifeImage").GetComponent<Image>();
            this._LifePropNumber = this.transform.Find("CardFace").Find("Life").GetComponent<PropNumber>();
            this._Card_BackImage = this.transform.Find("GameObject").Find("Card_Back").GetComponent<Image>();
            this._Card_CrossImage = this.transform.Find("GameObject").Find("Card_Cross").GetComponent<Image>();
        }
        [SerializeField()]
        private Image _CardBackImage;
        public Image CardBackImage
        {
            get
            {
                if ((this._CardBackImage == null))
                {
                    this._CardBackImage = this.transform.Find("CardBack").GetComponent<Image>();
                }
                return this._CardBackImage;
            }
        }
        [SerializeField()]
        private Image _Image_1;
        public Image Image_1
        {
            get
            {
                if ((this._Image_1 == null))
                {
                    this._Image_1 = this.transform.Find("CardBack").Find("Image_1").GetComponent<Image>();
                }
                return this._Image_1;
            }
        }
        [SerializeField()]
        private Image _Image_2;
        public Image Image_2
        {
            get
            {
                if ((this._Image_2 == null))
                {
                    this._Image_2 = this.transform.Find("CardBack").Find("Image_2").GetComponent<Image>();
                }
                return this._Image_2;
            }
        }
        [SerializeField()]
        private Image _ShadowImage;
        public Image ShadowImage
        {
            get
            {
                if ((this._ShadowImage == null))
                {
                    this._ShadowImage = this.transform.Find("CardFace").Find("Shadow").GetComponent<Image>();
                }
                return this._ShadowImage;
            }
        }
        [SerializeField()]
        private Image _BackgroundImage;
        public Image BackgroundImage
        {
            get
            {
                if ((this._BackgroundImage == null))
                {
                    this._BackgroundImage = this.transform.Find("CardFace").Find("Background").GetComponent<Image>();
                }
                return this._BackgroundImage;
            }
        }
        [SerializeField()]
        private Mask _Mask;
        public Mask Mask
        {
            get
            {
                if ((this._Mask == null))
                {
                    this._Mask = this.transform.Find("CardFace").Find("Mask").GetComponent<Mask>();
                }
                return this._Mask;
            }
        }
        [SerializeField()]
        private Image _Image;
        public Image Image
        {
            get
            {
                if ((this._Image == null))
                {
                    this._Image = this.transform.Find("CardFace").Find("Mask").Find("Image").GetComponent<Image>();
                }
                return this._Image;
            }
        }
        [SerializeField()]
        private Image _NameShadowImage;
        public Image NameShadowImage
        {
            get
            {
                if ((this._NameShadowImage == null))
                {
                    this._NameShadowImage = this.transform.Find("CardFace").Find("Mask").Find("NameShadow").GetComponent<Image>();
                }
                return this._NameShadowImage;
            }
        }
        [SerializeField()]
        private Text _NameText;
        public Text NameText
        {
            get
            {
                if ((this._NameText == null))
                {
                    this._NameText = this.transform.Find("CardFace").Find("Mask").Find("NameShadow").Find("NameText").GetComponent<Text>();
                }
                return this._NameText;
            }
        }
        [SerializeField()]
        private Text _DescText;
        public Text DescText
        {
            get
            {
                if ((this._DescText == null))
                {
                    this._DescText = this.transform.Find("CardFace").Find("Mask").Find("DescText").GetComponent<Text>();
                }
                return this._DescText;
            }
        }
        [SerializeField()]
        private Image _BorderImage;
        public Image BorderImage
        {
            get
            {
                if ((this._BorderImage == null))
                {
                    this._BorderImage = this.transform.Find("CardFace").Find("Border").GetComponent<Image>();
                }
                return this._BorderImage;
            }
        }
        [SerializeField()]
        private Image _CardFace_Image;
        public Image CardFace_Image
        {
            get
            {
                if ((this._CardFace_Image == null))
                {
                    this._CardFace_Image = this.transform.Find("CardFace").Find("Image").GetComponent<Image>();
                }
                return this._CardFace_Image;
            }
        }
        [SerializeField()]
        private Image _CostImage;
        public Image CostImage
        {
            get
            {
                if ((this._CostImage == null))
                {
                    this._CostImage = this.transform.Find("CardFace").Find("CostImage").GetComponent<Image>();
                }
                return this._CostImage;
            }
        }
        [SerializeField()]
        private PropNumber _CostPropNumber;
        public PropNumber CostPropNumber
        {
            get
            {
                if ((this._CostPropNumber == null))
                {
                    this._CostPropNumber = this.transform.Find("CardFace").Find("Cost").GetComponent<PropNumber>();
                }
                return this._CostPropNumber;
            }
        }
        [SerializeField()]
        private Image _AttackImage;
        public Image AttackImage
        {
            get
            {
                if ((this._AttackImage == null))
                {
                    this._AttackImage = this.transform.Find("CardFace").Find("AttackImage").GetComponent<Image>();
                }
                return this._AttackImage;
            }
        }
        [SerializeField()]
        private PropNumber _AttackPropNumber;
        public PropNumber AttackPropNumber
        {
            get
            {
                if ((this._AttackPropNumber == null))
                {
                    this._AttackPropNumber = this.transform.Find("CardFace").Find("Attack").GetComponent<PropNumber>();
                }
                return this._AttackPropNumber;
            }
        }
        [SerializeField()]
        private Image _LifeImage;
        public Image LifeImage
        {
            get
            {
                if ((this._LifeImage == null))
                {
                    this._LifeImage = this.transform.Find("CardFace").Find("LifeImage").GetComponent<Image>();
                }
                return this._LifeImage;
            }
        }
        [SerializeField()]
        private PropNumber _LifePropNumber;
        public PropNumber LifePropNumber
        {
            get
            {
                if ((this._LifePropNumber == null))
                {
                    this._LifePropNumber = this.transform.Find("CardFace").Find("Life").GetComponent<PropNumber>();
                }
                return this._LifePropNumber;
            }
        }
        [SerializeField()]
        private Image _Card_BackImage;
        public Image Card_BackImage
        {
            get
            {
                if ((this._Card_BackImage == null))
                {
                    this._Card_BackImage = this.transform.Find("GameObject").Find("Card_Back").GetComponent<Image>();
                }
                return this._Card_BackImage;
            }
        }
        [SerializeField()]
        private Image _Card_CrossImage;
        public Image Card_CrossImage
        {
            get
            {
                if ((this._Card_CrossImage == null))
                {
                    this._Card_CrossImage = this.transform.Find("GameObject").Find("Card_Cross").GetComponent<Image>();
                }
                return this._Card_CrossImage;
            }
        }
        partial void onAwake();
        public enum IsFaceup
        {
            False,
            True,
        }
        public IsFaceup IsFaceupController
        {
            get
            {
                return ((IsFaceup)(Enum.Parse(typeof(IsFaceup), this.getController("IsFaceup", Enum.GetNames(typeof(IsFaceup))))));
            }
            set
            {
                this.setController("IsFaceup", Enum.GetName(typeof(IsFaceup), value));
            }
        }
        public enum Type
        {
            Servant,
            Spell,
        }
        public Type TypeController
        {
            get
            {
                return ((Type)(Enum.Parse(typeof(Type), this.getController("Type", Enum.GetNames(typeof(Type))))));
            }
            set
            {
                this.setController("Type", Enum.GetName(typeof(Type), value));
            }
        }
    }
}
