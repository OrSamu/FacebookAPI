using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public interface IPhotoData
    {
        List<string> GetData(Photo i_PhotoSource);
    }
}
