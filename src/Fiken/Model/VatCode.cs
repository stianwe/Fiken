using System.Collections.Generic;

namespace Fiken.Model;

public enum VatCodeValidFor
{
    Sales,
    Purchases,
    SalesAndPurchases,
}

public record VatCode(string Code, string Description, VatCodeValidFor ValidFor);

public class Vat
{
    public static readonly List<VatCode> Codes =
    [
        new("0", "Ingen", VatCodeValidFor.SalesAndPurchases),
        new("1", "Høy sats", VatCodeValidFor.SalesAndPurchases),
        new("11", "Medium stats", VatCodeValidFor.SalesAndPurchases),
        new("12", "Rå fisk", VatCodeValidFor.SalesAndPurchases),
        new("13", "Lav stats", VatCodeValidFor.SalesAndPurchases),
        new("52", "Fritatt import/eksport", VatCodeValidFor.Sales),
        new("5", "Fritatt", VatCodeValidFor.Sales),
        new("6", "Fritatt, utenfor avgiftsområde", VatCodeValidFor.Sales),
        new("51", "Fritatt omvendt", VatCodeValidFor.Sales),
        new("14", "Høy direkte", VatCodeValidFor.Purchases),
        new("21", "Høy grunnlag", VatCodeValidFor.Purchases),
        new("15", "Middels direkte", VatCodeValidFor.Purchases),
        new("22", "Middels grunnlag", VatCodeValidFor.Purchases),
        new("23", "Ingen import grunnlag", VatCodeValidFor.Purchases),
        new("86", "Tjeneste kjøpt fra utlandet med fradrag for høy MVA", VatCodeValidFor.Purchases),
        new("87", "Tjeneste kjøpt fra utlandet uten fradrag for høy MVA", VatCodeValidFor.Purchases),
        new("88", "Tjeneste kjøpt fra utlandet med fradrag for lav MVA", VatCodeValidFor.Purchases),
        new("89", "Tjeneste kjøpt fra utlandet uten fradrag for lav MVA", VatCodeValidFor.Purchases),
        new("91", "Kjøp av klimakvote eller gull med fradrag for MVA", VatCodeValidFor.Purchases),
        new("92", "Kjøp av klimakvote eller gull uten fradrag for MVA", VatCodeValidFor.Purchases),
    ];
}