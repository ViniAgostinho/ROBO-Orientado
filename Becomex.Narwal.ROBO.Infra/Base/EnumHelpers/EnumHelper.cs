using System;
using System.ComponentModel;
using System.Reflection;

namespace Becomex.Narwal.ROBO.Infra.Base.EnumHelpers
{
    public static class EnumHelper
    {
        public static string MontaDescricaoEnum(Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] array = null;
            try
            {
                array = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), inherit: false);
                if (array != null && array.Length != 0)
                {
                    return array[0].Description;
                }

                return "Descrição para " + value.ToString() + " não especificado";
            }
            catch (Exception)
            {
                return value.ToString() + " não é um valor válido para o Enum";
            }
        }
    }
}
