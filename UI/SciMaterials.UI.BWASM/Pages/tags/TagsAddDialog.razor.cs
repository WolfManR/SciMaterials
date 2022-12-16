using Microsoft.AspNetCore.Components;
using MudBlazor;
using SciMaterials.Contracts.API.DTO.Tags;
using SciMaterials.Contracts.WebApi.Clients.Tags;
using SciMaterials.UI.BWASM.Pages.urls;

namespace SciMaterials.UI.BWASM.Pages.tags;

public partial class TagsAddDialog
{
    [Inject] private ITagsClient _TagsClient { get; set; }
    [Inject] private ISnackbar _Snackbar { get; set; }
    [Parameter] public DialogTypes DialogType { get; set; }
    [Parameter] public AddTagRequest AddTagsModel { get; set; } = new();
    [CascadingParameter] private MudDialogInstance _MudDialog { get; set; }

    private async Task OnSaveClickAsync()
    {
        var result = await _TagsClient.AddAsync(AddTagsModel, new CancellationToken()).ConfigureAwait(false);
        if (result.Succeeded)
        {
            _Snackbar.Add("Tag has been saved", Severity.Success);
            _MudDialog.Close();
        }
        else
        {
            _Snackbar.Add("Tag has NOT been saved!", Severity.Error);
        }
    }

    private void OnCancelClick()
    {
        _MudDialog.Cancel();
    }
}
