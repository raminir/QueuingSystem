using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Implementation.ApiServices.General
{
    public enum ErrorCode
    {
        [Display(Name = "والد وجود ندارد.")]
        Catalog_ParentNotFound = 1010,

        [Display(Name = "دسته بندی وجود ندارد.")]
        Catalog_CategoryNotFound = 1011,

        [Display(Name = "محصول وجود ندارد.")]
        Catalog_ProductNotFound = 1012,

        [Display(Name = "ویژگی وجود ندارد.")]
        Catalog_AttributeNotFound = 1013,

        [Display(Name = "آپشن وجود ندارد.")]
        Catalog_OptionNotFound = 1014,

        [Display(Name = "فروشگاه وجود ندارد.")]
        Catalog_StoreNotFound = 1015,

        [Display(Name = "تصویر وجود ندارد.")]
        Catalog_ImageNotFound = 1016,

        [Display(Name = "محصول در این دسته بندی نیست.")]
        Catalog_ProductNotInCategory = 1017,

        [Display(Name = "محصول از قبل در این دسته بندی بوده است.")]
        Catalog_ProductAlreadyInCategory = 1018,

        [Display(Name = "ویژگی در این دسته بندی نیست.")]
        Catalog_AttributeNotInCategory = 1019,

        [Display(Name = "ویژگی از قبل در این دسته بندی بوده است.")]
        Catalog_AttributeAlreadyInCategory = 1020,

        [Display(Name = "آپشن در این دسته بندی نیست.")]
        Catalog_OptionNotInCategory = 1021,

        [Display(Name = "آپشن از قبل در این دسته بندی بوده است.")]
        Catalog_OptionAlreadyInCategory = 1022,

        [Display(Name = "تصویر تکراری است.")]
        Catalog_DuplicateImage = 1023,

        [Display(Name = "فروشگاه تکراری است.")]
        Catalog_DuplicateStore = 1024,

        [Display(Name = "آپشن برای این محصول مجاز نیست.")]
        Catalog_NotAllowedOption = 1025,

        [Display(Name = "ویژگی برای این محصول مجاز نیست.")]
        Catalog_NotAllowedAttribute = 1026,

        [Display(Name = "یک یا چند دسته بندی انتخاب شده مجاز به دریافت محصول نیستند.")]
        Catalog_CategoriesHasChildren = 1027,

        [Display(Name = "ویژگی اختصاصی محصول وجود ندارد.")]
        Catalog_SpecificAttributeNotFound = 1028,

        [Display(Name = "دسته بندی فروشگاه باید وارد شود.")]
        Catalog_StoreCategoryIsRequired = 1029,

        [Display(Name = "دسته بندی تامین کننده باید وارد شود.")]
        Catalog_SupplierCategoryisRequired = 1030,

        [Display(Name = "امکان نمایش محصول در فروشگاه در صورت وجود محصول در پیش نویس وجود ندارد.")]
        Catalog_ProductIsInDraft = 1031,

        [Display(Name = "کاربر نمیتواند بیش از یک ریویو فعال برای یک محصول ثبت کند.")]
        Review_UserHasActiveReview = 1110,

        [Display(Name = "آدرس تکراری است.")]
        Location_AddressIsDuplicated = 1210,

        [Display(Name = "فایل خالی است.")]
        FileManager_NullOrEmptyFile = 1310,

        [Display(Name = "نوع فایل غیرمجاز است.")]
        FileManager_NotAllowedContentType = 1311,

        [Display(Name = "خطای پیشبینی نشده.")]
        SEO_UnhandledDbError = 1410,

        [Display(Name = "کیف پول قفل شده است.")]
        Wallet_WalletIsLocked = 1510,

        [Display(Name = "عدم موجودی.")]
        Wallet_LackOfWalletBalance = 1511,

        [Display(Name = "مبلغ معتبر نیست.")]
        Wallet_InvalidAmount = 1512,

        [Display(Name = "خطای پیشبینی نشده.")]
        Wallet_UnhandledDbError = 1513,

        [Display(Name = "فروشگاه برای ثبت نام اعتبار ندارد.")]
        Stores_StoreNotValidForCustomerRegistration = 1610,

        [Display(Name = "فروشگاه از قبل در این دسته بندی بوده است.")]
        Stores_StoreAlreadyInCategory = 1611,

        [Display(Name = "فروشگاه از قبل در این طرف سازمانی بوده است.")]
        Stores_StoreAlreadyInOrganization = 1612,

        [Display(Name = "فروشگاه از قبل این کاربر را داشته است.")]
        Stores_StoreAlreadyHasUser = 1613,

        [Display(Name = "فروشگاه از قبل این آدرس را داشته است.")]
        Stores_StoreAlreadyHasAddress = 1614,

        [Display(Name = "فروشگاه پیدا نشد.")]
        Stores_CategoryNotFound = 1615,

        [Display(Name = "دسته بندی دارای چندین فروشگاه است.")]
        Stores_CategoryHasManyStore = 1616,

        [Display(Name = "بیشتر از یک آیتم وجود دارد.")]
        Stores_MoreThanOneElement = 1617,

        [Display(Name = "رنک پیدا نشد.")]
        Stores_RankNotFound = 1618,

        [Display(Name = "آیتم فروش تکراری است.")]
        Pricing_SalesItemAlreadyExists = 2310,

        [Display(Name = "تداخل در وبسایت ها.")]
        Pricing_WebsiteHasConflict = 2311,

        [Display(Name = "هیچ الگویی برای این وبسایت تعریف نشده است.")]
        Pricing_NothingMatchedWebsiteWasFound = 2312,

        [Display(Name = "لینک یا ساختار صفحه وب نامعتبر است (خطا در دریافت قیمت).")]
        Pricing_InvalidLinkOrWebPage = 2313,

        [Display(Name = "گروه تیکت وجود ندارد.")]
        Ticket_TicketTypeNotFound = 2210,

        [Display(Name = "تیکت وجود ندارد.")]
        Ticket_TicketNotFound = 2211,

        [Display(Name = "تیکت بسته شده است.")]
        Ticket_TicketIsClosed = 2212,

        [Display(Name = "تعداد تیکت های باز بیش از حد مجاز است.")]
        Ticket_TooManyOpenedTicket = 2213,

        [Display(Name = "دسته بندی از قبلا وجود دارد.")]
        Blog_CategoryAlreadyAdded = 1810,

        [Display(Name = "دسته بندی وجود ندارد.")]
        Blog_CategoryNotFound = 1811,

        [Display(Name = "کامنت پدر وجود ندارد.")]
        Blog_ParentNotFound = 1812,

        [Display(Name = "کامنت تایید نشده است.")]
        Blog_CommentIsNotConfirmed = 1813,

        [Display(Name = "پست بلاگ وجود ندارد.")]
        Blog_PostNotFound = 1814,

        [Display(Name = "اسلاگ تکراری است")]
        Blog_SlugDublicated,

        [Display(Name = "هنوز از زمان تاریخ پیگیری بعدی نگذشته است")]
        Order_NextFollowUpDateIsNotReached = 2568,

        [Display(Name = "فاکتور فریز نشده")]
        Invoice_InvoiceIsNotFreezed = 2582,

        [Display(Name = "وضعیت چک ها نا مشخص است")]
        Order_OrderIdOrSayyadChequesNotFound = 2594,

        [Display(Name = "فاکتور با مشتری تسویه شده")]
        InvoiceIsSettledWithCustomer = 2543,

        [Display(Name = "درخواست خرید اقساطی تایید شده است")]
        Order_OrderAlreadyConfirmed = 2548,


        [Display(Name = "تاریخ کنسلی قبل از تاریخ فاکتور")]
        Invoice_CancelationDateIsBeforeInvoiceDate = 2556,

        [Display(Name = "شماره چک نمیتواند تکراری باشد")]
        ChequeNumberIsExistInDb = 25104,

        [Display(Name = "تعداد ماه اقساط اشتباه است یا برابر با تعداد اقساطی که در فاکتور ثبت شده نیست.")]
        InvalidNumberOfInstallment = 2571,

        [Display(Name = "در این نوع خرید نمیتوانید قسط ثبت کنید.")]
        TheGuaranteeTypeNotAcceptInstallment = 2572,

        [Display(Name = "بعد از فریز امکان ویرایش نوع خرید وجود ندارد.")]
        InvoiceIsFreezedYouCantUpdateGuaranteeType = 2595,

        [Display(Name = "فاکتور فریز است.")]
        InvoiceIsFreezed = 2580,

        [Display(Name = "چک به بانک واگذار شده است")]
        ChequeIsAssigned = 2577,

        [Display(Name = "فاکتور پرداختی دارد")]
        InvoiceHasSomePayment = 2554,

        [Display(Name = "فاکتور با فروشگاه تسویه نشده")]
        InvoiceIsNotSettledWithStore = 2553,

        [Display(Name = "مبلغ فاکتور مجاز نیست")]
        InvalidInvoiceAmount = 2560,

        [Display(Name = "این فاکتور از قبل تایید نهایی شده است")]
        InvoiceAlreadyFreezed = 2569,

        [Display(Name = "چک در حال حاضر برگشت خورده")]
        ChequeAlreadyBounced = 2549,

        [Display(Name = "تاریخ چک هنوز نرسیده")]
        ChequeDueDateIsNotReached = 2550,

        [Display(Name = "لطفا احراز گر را انتخاب نمایید")]
        PleaseInputAuthenticatorId = 2593,

        [Display(Name = "چک موجود نیست")]
        ChequeNotFound = 2539,

        [Display(Name = "تاریخ اشتباه است")]
        DateIsNotValid = 25124,

        [Display(Name = "سابقه حقوقی یافت نشد")]
        LegalLevelNotFound = 2541,

        [Display(Name = "این رکورد به سطح بستگی دارد")]
        SomeRecordDependsOnTheLevel = 2566,

        [Display(Name = "چک قبلا وصول شده")]
        ChequeAlreadyCleared = 2557,

        [Display(Name = "فروشگاه این نوع ضمانت را پشتیبانی نمیکند.")]
        GuaranteeTypeNotSupportedByStore = 2528,

        [Display(Name = "نتیجه تاییدی نیست پس موارد را برسی نمایید")]
        OrderIsNotConfirmed = 2537,

        [Display(Name = "مبلغ وارد شده صحیح نمیباشد")]
        StoreSettlementFeeIsNotValid = 25159,

        [Display(Name = "InvalidRole")]
        InvalidRole = 2601,

        [Display(Name = "DuplicateUserName")]
        DuplicateUserName = 2602,

        [Display(Name = "DuplicateRoleName")]
        DuplicateRoleName = 2603,

        [Display(Name = "InvalidPassword")]
        InvalidPassword = 2604,

        [Display(Name = "IncorrectPassword")]
        IncorrectPassword = 2605,

        [Display(Name = "RoleAssignedToSomeUsers")]
        RoleAssignedToSomeUsers = 2606,

        [Display(Name = "برای این پرداختی از قبل واریزی ثبت شده است")]
        PaymentIsDuplicated = 25158,
    }
}
