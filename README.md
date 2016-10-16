# net.fw.abp.zero
This is demo of asp.net boilerplate zero module

## Sơ lược kiến trúc hệ thống
- Hệ thống hổ trợ phát triển ứng dụng đa hệ thống user ( giống hình thức cho nhiều đối tác cùng thuê sử dụng 1 sản phẩm , chạy trên 1 hoặc nhiều database, trên 1 hoặc nhiều server.
- Có 2 đối tượng cơ bản của kiến trúc:
  + tenant: được coi như là 1 KH sử dụng ứng dụng, có hệ thống user riêng, hệ thống quyền riêng, các cấu hình riêng,... và sử dụng các tính năng trên ứng dụng hoàn toàn tách biệt với các tenant (KH) khác. 
  + host: có thể hiểu như người quản trị các tenants 
- Có thể truy cập current user ( hoặc là tenant user (TenantId != NULL), hoặc là host (TenantId = NULL)) từ interface IAbpSession 
- Tất cả các truy vấn data từ database đều được tự động filter theo scope của current user => dữ liệu của mỗi KH đều được tách biệt với các KH khác

(Tham khảo: http://www.aspnetboilerplate.com/Pages/Documents/Multi-Tenancy)

### Các tính năng cần lưu ý trong kiến trúc hệ thống
- Tenant Management
Hệ thống có thể chạy ở chế độ Milti-Tenant hoặc Single-Tenant. Mặc định là Single-Tenant.

Để bật chế độ Multi-Tenant cấu hình:
```C#
[DependsOn(typeof(AbpZeroCoreModule))]
public class MyCoreModule : AbpModule
{
    public override void PreInitialize()
    {
        Configuration.MultiTenancy.IsEnabled = true;    
    }

    ...
}
```

- Edition Management
Hổ trợ phân chia các tính năng trong hệ thống thành các package khác nhau. Cho phép KH có thể chọn lựa những package khác nhau theo giá hay tùy chọn về tính năng.

(Tham khảo: http://www.aspnetboilerplate.com/Pages/Documents/Feature-Management)

- User Management

Quản lý user cũng như thiết lập các cơ chế Login liên quan trong hệ thống.

(Tham khảo: http://www.aspnetboilerplate.com/Pages/Documents/Zero/User-Management)

- Role Management

Quản lý quyền, phân quyền cho user trong hệ thống.

(Tham khảo: http://www.aspnetboilerplate.com/Pages/Documents/Zero/Role-Management)

- Organization Unit (OU) Management 

OU dùng để thể hiện mối liên kết giữa các thực thể có trong hệ thống với từng user.

VD:
Định nghĩa class Product
```
public class Product : Entity, IMustHaveTenant, IMustHaveOrganizationUnit
{
    public virtual int TenantId { get; set; }

    __public virtual long OrganizationUnitId { get; set; }__
    
    public virtual string Name { get; set; }

    public virtual float Price { get; set; }
}
```
Lấy danh sách sản phẩm của 1 user:
```
public async Task<List<Product>> GetProductsForUserAsync(long userId)
{
    var user = await _userManager.GetUserByIdAsync(userId);
    var organizationUnits = await _userManager.GetOrganizationUnitsAsync(user);
    var organizationUnitIds = organizationUnits.Select(ou => ou.Id);

    return await _productRepository.GetAllListAsync(p => organizationUnitIds.Contains(p.OrganizationUnitId));
}
```
(Tham khảo: http://www.aspnetboilerplate.com/Pages/Documents/Zero/Organization-Units)

- Permission Management

Thực hiện việc định nghĩa và check permission của 1 User hoặc Role được phép thực hiện 1 hành động nào đó trong hệ thống hay không.

(Tham khảo: http://www.aspnetboilerplate.com/Pages/Documents/Zero/Permission-Management)

- Language Management

Hổ trợ đa ngôn ngữ static/dynamic text hiển thị.

Hổ trợ nhiều cách và tùy chỉnh để thực hiện : XML resource, json resource, embed resource, database store

(Tham khảo: http://www.aspnetboilerplate.com/Pages/Documents/Zero/Language-Management)

## Demo
1. Phrase 1
. Tạo module Contact Management: ContactGroup, Contact
. Viết UnitTest cho các ApplicationService cho các đối tượng 
. Viết các Action tạo, sửa, xóa ContactGroup, Contact

2. Phrase 2
. Phân quyền cho module Contact Management

3. Phrase 3
. Ứng dụng Multi Tenancy cho module Contact Management
