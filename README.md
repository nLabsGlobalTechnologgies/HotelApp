Turkish:
## HotelApp Projesi

Bu proje, C# .NET 7 kullanılarak geliştirilen bir otel uygulamasını içerir. Aşağıda projenin ana bileşenlerini ve bazı özelliklerini bulabilirsiniz:

- **Business**: Uygulamanın iş mantığını içeren projedir.
- **Entities**: Uygulamanın veri modelini tanımlayan projedir.
- **Interfaces**: Uygulamanın farklı bileşenleri arasındaki arabirimleri içeren projedir.
- **DataAccess**: Veritabanı işlemlerini gerçekleştiren projedir.
- **WindowsApp**: Uygulamanın kullanıcı arayüzünü içeren Windows Uygulaması projedir.

Ayrıca, bu proje Singleton tasarım desenini kullanmaktadır.

### İlerideki Güncellemeler

Bu projede Entity Framework Core ve NHibernate gibi ORM (Nesne İlişkilendirme Yöntemleri) kullandığınızı belirttiniz. Bu nedenle, gelecekte bu ORM'leri kullanarak veri tabanı işlemlerini optimize etmeyi düşünüyorsunuz.

GitHub Proje Bağlantısı: [GitHub HotelApp Projesi](https://github.com/nLabsGlobalTechnologgies/HotelApp)

Projeyle ilgili daha fazla detay ve kodları projenin GitHub sayfasından inceleyebilirsiniz.

English:
## HotelApp Project

This project contains a hotel application developed using C# .NET 7. Below, you can find the main components of the project and some features:

- **Business**: The project that contains the business logic of the application.
- **Entities**: The project that defines the data model of the application.
- **Interfaces**: The project that includes interfaces between different components of the application.
- **DataAccess**: The project responsible for database operations.
- **WindowsApp**: The Windows Application project that contains the user interface of the application.

Additionally, this project utilizes the Singleton design pattern.

### Future Updates

You mentioned using Object-Relational Mapping (ORM) tools like Entity Framework Core and NHibernate in this project. Therefore, you are considering optimizing database operations using these ORM tools in the future.

GitHub Project Link: [GitHub HotelApp Project](https://github.com/nLabsGlobalTechnologgies/HotelApp)

You can explore more details and the project's code on the project's GitHub page.

## Hotel Category Management

In this scenario, we have a Windows Forms application for managing hotel categories. It uses the `CategoryManager` class for various operations.

### Displaying Categories

```csharp
void ToList()
{
    dgvCategory.DataSource = categoryManager.Select();
}

When the application loads, it fetches and displays a list of hotel categories from the database using the Select method from the CategoryManager.

Adding a Category
private void btnSave_Click(object sender, EventArgs e)
{
    if (txtName.Text.Length != 0)
        category.Name = txtName.Text;
    else
    {
        MessageBox.Show("Category Name Null Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }
    if (categoryManager.Insert(category))
    {
        MessageBox.Show("Category addition was successful");
        ToList();
        txtName.Text = "";
    }
    else
    {
        MessageBox.Show("An error occurred while adding the category!");
    }
}

The "Save" button (btnSave) allows you to add a new category to the database. It checks if the category name is not empty, creates a new Category object, and inserts it into the database using the Insert method from the CategoryManager.

Updating a Category

private void btnUpdate_Click(object sender, EventArgs e)
{
    if (txtName.Text.Length != 0)
    {
        category.Id = id;
        category.Name = txtName.Text;
    }
    else
    {
        MessageBox.Show("Please select the category you want to update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }
    if (categoryManager.Update(category))
    {
        MessageBox.Show("Category update successful");
        ToList();
        txtName.Text = "";
    }
    else
    {
        MessageBox.Show("An error occurred while updating the category!");
    }
}

The "Update" button (btnUpdate) allows you to modify an existing category. It checks if the category name is not empty, updates the selected category using the Update method from the CategoryManager, and refreshes the category list.

Deleting a Category

private void btnDelete_Click(object sender, EventArgs e)
{
    if (txtName.Text.Length != 0)
    {
        category.Id = id;
        category.Name = txtName.Text;
    }
    else
    {
        MessageBox.Show("Please select the category you want to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }
    if (categoryManager.Delete(category))
    {
        MessageBox.Show("Category deletion was successful");
        ToList();
        txtName.Text = "";
    }
    else
    {
        MessageBox.Show("An error occurred while deleting the category!");
    }
}

The "Delete" button (btnDelete) enables you to remove a category from the database. It verifies if the category name is not empty, deletes the selected category using the Delete method from the CategoryManager, and updates the category list.

This Markdown provides an overview of a basic hotel category management application with functionalities for adding, updating, and deleting categories.
