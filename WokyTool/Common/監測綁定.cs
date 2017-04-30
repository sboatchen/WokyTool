using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WokyTool.Common
{
    public delegate void BindingUpdate<T>(List<T> Data_);

    public class 監測綁定更新<T>
    {
        public BindingUpdate<T> Call { get; private set; }
        public int UpdateUID{ get; private set; }
        public 監測綁定廣播<T> BroadCaster{ get; private set; }

        public 監測綁定更新(監測綁定廣播<T> BroadCaster_, BindingUpdate<T> Call_)
        {
            Call = Call_;
            UpdateUID = 0;

            BroadCaster = BroadCaster_;
        }

        public bool Update(bool Force_ = false)
        {
            if (BroadCaster != null)
                return BroadCaster.Update(this, Force_);

            return false;
        }

        public void Notify(int NewUID_, List<T> ItemResult_)
        {
            UpdateUID = NewUID_;
            Call(ItemResult_);
        }

        public IEnumerable<T> Query
        {
            get {
                return BroadCaster.Query; 
            }
        }
    }

    public class 監測綁定廣播<T>
    {
        public IEnumerable<T> Query { get; protected set; }
        
        protected List<T> _Data;
        public List<T> Data 
        {
            get
            {
                UpdateData();
                return _Data;
            }
        }

        protected bool _IsDirty;
        public int UpdateUID { get; private set; }

        public 監測綁定廣播(IEnumerable<T> ItemQuery_)
        {
            Query = ItemQuery_;
            _IsDirty = true;
        }

        public void SetDirty()
        {
            _IsDirty = true;
        }

        protected void UpdateData()
        {
            if (_IsDirty)
            {
                _IsDirty = false;
                _Data = Query.ToList();
                UpdateUID++;
            }
        }

        public bool Update(監測綁定更新<T> Target_, bool Force_ = false)
        {
            UpdateData();

            if (Target_.UpdateUID != UpdateUID || Force_)
            {
                Target_.Notify(UpdateUID, Data);
                return true;
            }

            return false;
        }
    }
}
