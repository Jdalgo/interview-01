using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharp
{
    public static class DriverLicense
    {
        /// <summary>
        /// Consider this list of formats: https://ntsi.com/drivers-license-format/
        /// Validate Driver's license number, implement Nebraska and Mississippi in an expandable way to eventually handle all US states.
        /// Fail validation if unexpected data is passed in.
        /// Nebraska: 1Alpha+6-8Numeric
        /// Mississippi: 9Numeric
        /// </summary>
        /// <param name="licenseNumber"></param>
        /// <param name="stateCode"></param>
        /// <returns></returns>
        public static bool Validate(string licenseNumber, string stateCode)
        {
            bool result = false;

            switch (stateCode)
            {
                case "MS":
                    result = ValidatePlate(licenseNumber, "^[0-9]{9}$");
                    break;
                case "NE":
                    result = ValidatePlate(licenseNumber, "^[a-zA-Z]{1,1}[0-9]{6,8}$");
                    break;
                case "CA":
                    result = ValidatePlate(licenseNumber, "^[a-zA-Z]{1,1}[0-9]{9}$");
                    break;
                default:
                    result = false;
                    break;

            }
            return result;
        }
        private static bool ValidatePlate(string licenseNumber, string pattern)
        {
            var licenseRegex = new Regex(pattern);
            return licenseRegex.IsMatch(licenseNumber);
        }
    }
}
