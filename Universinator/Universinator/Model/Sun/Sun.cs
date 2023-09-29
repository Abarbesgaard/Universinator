using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universinator.Model.Sun
{
    public record Star(
        float Identifier,
        bool IsActive,
        SunDescription SunDescription
        );
}
