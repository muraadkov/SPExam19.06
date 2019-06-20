using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SPExam19._06
{
    public class Check
    {
        public bool ValidationCheck(User user)
        {
            int lengthPassword = user.Password.Length;
            int minimalLengthOfPassword = 8;
            try
            {
                if (user.Login.Contains(" ") | string.IsNullOrEmpty(user.Login))
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Логин не соответствует требованиям");
                throw new ArgumentException();
            }
            try
            {
                if (!user.Email.Contains('@') | !user.Email.Contains('.'))
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("E-mail не соответствует требованиям");
                throw new ArgumentException();
            }
            try
            {
                if (lengthPassword < minimalLengthOfPassword)
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Пароль не соответствует требованиям");
                throw new ArgumentException();
            }
            try
            {
                if (!user.Password.Contains('!') && !user.Password.Contains('$') && !user.Password.Contains('%') && !user.Password.Contains(':') && !user.Password.Contains('?') && !user.Password.Contains('&') && !user.Password.Contains('*') && !user.Password.Contains('(') && !user.Password.Contains(')') && !user.Password.Contains('+') && !user.Password.Contains('-') && !user.Password.Contains(']') && !user.Password.Contains('[') && !user.Password.Contains('\'') && !user.Password.Contains('/') && !user.Password.Contains('.') && !user.Password.Contains('?') && !user.Password.Contains('<') && !user.Password.Contains('>'))
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Пароль не соответствует требованиям");
                throw new ArgumentException();
            }
            try
            {
                if (!user.Password.Any(Char.IsNumber) || !user.Password.Any(Char.IsUpper) || !user.Password.Any(Char.IsLower))
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Пароль не соответствует требованиям");
                throw new ArgumentException();
            }
            try
            {
                if (user.DoublePassword != user.Password)
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Пароли не совпадают");
                throw new ArgumentException();
            }
            try
            {
                if (string.IsNullOrEmpty(user.MobileNumber) || user.MobileNumber.Length > 12 || user.MobileNumber.Contains('-') || user.MobileNumber.Contains(' '))
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("Мобильный телефон неверный");
                throw new ArgumentException();
            }
            return true;

        }
    
    }
}