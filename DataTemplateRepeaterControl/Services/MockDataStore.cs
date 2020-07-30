using DataTemplateRepeaterControl.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataTemplateRepeaterControl.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> _items;

        public MockDataStore()
        {
            _items = new List<Item>();
            List<Item> mockItems = new List<Item>
            {
                new ItemA { Id = Guid.NewGuid().ToString(), Role = "GOVERNMENT", CredentialName = "Government Of Canada\nBirth Certificate", CredentialDesc="Country: Canada\nName: Andrew Starling\nDate of Birth: 01/01/70\nProvince: Ontario\nCity: Toronto\nIssue Date: 03/16/20", CredentialGroup = "ribbon.png" },
                new ItemA { Id = Guid.NewGuid().ToString(), Role = "FINANCIAL", CredentialName = "Bank Of Montreal\nMasterCard", CredentialDesc="Card Number: 1234567890123\nCardholder Name: Andrew Starling\nExpiration Date: 02/03/25\nCVV: 555\nCredit Limit: $5000\nCurrent Balance: $532.86\nInterest Rate: 19.5%\nRewards Program: Y", CredentialGroup = "creditcard.png" },
                new ItemA { Id = Guid.NewGuid().ToString(), Role = "RETAIL", CredentialName = "Starbucks Rewards Card", CredentialDesc="Name: Andrew Starling\nE-mail:andrew@canacred.ca\nPassword:qwerty11\nPoints: 253\nMember Since: 02/11/15", CredentialGroup = "cafe.png" },
                new ItemA { Id = Guid.NewGuid().ToString(), Role = "EDUCATION", CredentialName = "George Brown College", CredentialDesc="Name: Andrew Starling\nStudent ID: 100191710\nMajor: Computer Science\nStart Date: 07/09/2010\nEnd Date: 22/04/2013\nGraduated: Yes" , CredentialGroup = "school.png" },
                new ItemA { Id = Guid.NewGuid().ToString(), Role = "GOVERNMENT", CredentialName = "Ontario Driving License", CredentialDesc="Province: Ontario\nName: Andrew Starling\nExpiry Date: 01/01/30", CredentialGroup = "car.png" },
                new ItemA { Id = Guid.NewGuid().ToString(), Role = "TRANSPORTATION", CredentialName = "Toronto Transit Commission\nMetropass", CredentialDesc="Name: Andrew Starling\nID: 84026220\nValid: July 2020\nAdult Fare", CredentialGroup = "subway.png" },
                new ItemA { Id = Guid.NewGuid().ToString(), Role = "RETAIL", CredentialName = "Shoppers Drug Mart Optimum", CredentialDesc="Card Number: 1094531288229001\nName: Andrew Starling\nE-mail: andrew@canacred.ca\n Password: qwerty22\nRewards Points: 12005\nMember Since: 01/01/20", CredentialGroup = "pharmacy.png" },
                new ItemA { Id = Guid.NewGuid().ToString(), Role = "FINANCIAL", CredentialName = "Toronto Dominion Bank\nVISA", CredentialDesc="Card Number: 1234567890123\nCardholder Name: Andrew Starling\nExpiration Date: 02/03/25\nCVV: 555\nCredit Limit: $5000\nCurrent Balance: $532.86\nInterest Rate: 21.5%\nRewards Program: Y", CredentialGroup = "creditcard.png" },
                new ItemA { Id = Guid.NewGuid().ToString(), Role = "RETAIL", CredentialName = "Petro-Canada Points Card", CredentialDesc="Card Number: 3362091\nCardholder Name: Andrew Starling\nExpiration Date: 12/03/22\nCredit Limit: $5000\nPoints Balance: 21003\n", CredentialGroup = "gas.png" }
            };

            foreach (var item in mockItems)
            {
                _items.Add(item);
            }
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(_items);
        }
    }
}