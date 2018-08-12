using Remotion.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WokyTool.Common
{
    public delegate void BindingUpdate<T>(IEnumerable<T> Data_);

    public class 監測綁定更新<T>
    {
        public BindingUpdate<T> Call { get; protected set; }
        public int UpdateUID { get; protected set; }
        public 監測綁定廣播<T> BroadCaster { get; protected set; }

        public 舊列舉.監測類型 _Type;
        public 舊列舉.監測類型 Type
        {
            get
            {
                return _Type;
            }
            set
            {
                if (_Type == value)
                    return;

                _Type = value;
                if (_Type.IsActive())
                    BroadCaster.Regist(this);
                else
                    BroadCaster.Unregist(this);
            }
        }

        public 監測綁定更新(監測綁定廣播<T> BroadCaster_, 舊列舉.監測類型 Type_, BindingUpdate<T> Call_)
        {
            Call = Call_;
            UpdateUID = 0;

            BroadCaster = BroadCaster_;
            Type = Type_;
        }

        ~監測綁定更新()
        {
            if (BroadCaster != null)
                BroadCaster.Unregist(this);
        }

        public bool Refresh(bool Force_ = false)
        {
            if (BroadCaster != null)
                return BroadCaster.PassiveUpdate(this, Force_);

            return false;
        }

        public void Notify(int NewUID_)
        {
            UpdateUID = NewUID_;

            if (Type.IsReturnValue())
                Call(BroadCaster.Data);
            else
                Call(BroadCaster.Query);
        }

        public IEnumerable<T> Query
        {
            get
            {
                return BroadCaster.Query;
            }
        }

        public List<T> Data
        {
            get
            {
                return BroadCaster.Data;
            }
        }
    }

    public class 監測綁定廣播<T>
    {
        protected HashSet<監測綁定更新<T>> _RegistList;
        // 資料來源更新到第幾版
        protected int _UpdateUID;
        // 暫存的資料列表到第幾版
        protected int _DataUID;

        public IEnumerable<T> Query { get; protected set; }

        protected List<T> _Data;
        public List<T> Data 
        {
            get
            {
                if (_DataUID != _UpdateUID)
                {
                    _DataUID = _UpdateUID;
                    _Data = Query.ToList();
                }
                return _Data;
            }
        }

        public 監測綁定廣播(IEnumerable<T> ItemQuery_)
        {
            Query = ItemQuery_;

            _RegistList = new HashSet<監測綁定更新<T>>();
            _UpdateUID = 1;
            _DataUID = 0;
        }

        public void Regist(監測綁定更新<T> Target_)
        {
            _RegistList.Add(Target_);
        }

        public void Unregist(監測綁定更新<T> Target_)
        {
            _RegistList.Remove(Target_);
        }

        public void SetDirty()
        {
            _UpdateUID++;

            ActiveUpdate();
        }

        protected void ActiveUpdate()
        {
            foreach (var Listener_ in _RegistList)
                Listener_.Notify(_UpdateUID);
        }

        public bool PassiveUpdate(監測綁定更新<T> Listener_, bool Force_ = false)
        {
            if (Listener_.UpdateUID != _UpdateUID || Force_)
            {
                Listener_.Notify(_UpdateUID);
                return true;
            }

            return false;
        }
    }
}
