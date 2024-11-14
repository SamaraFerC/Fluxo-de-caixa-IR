function confirmDelete(activityId) {
    const userConfirmed = confirm("Tem certeza de que deseja excluir este colaborador ?");

    if (userConfirmed) {
        $.ajax({
            url: '/Collaborator/Delete',
            type: 'POST',
            data: { id: activityId },
            success: function (response) {
                if (response.success) {
                    const row = document.getElementById(`row-${activityId}`);
                    if (row) row.remove();
                    alert("colaborador excluído com sucesso.");
                } else {
                    alert("Falha ao excluir o colaborador.");
                }
            },
            error: function () {
                alert("Ocorreu um erro ao tentar excluir a colaborador.");
            }
        });
    }
}