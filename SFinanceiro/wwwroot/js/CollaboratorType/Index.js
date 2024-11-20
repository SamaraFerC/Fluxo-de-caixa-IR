function confirmDelete(activityId) {
    const userConfirmed = confirm("Tem certeza de que deseja excluir este tipo de Colaborador?");

    if (userConfirmed) {
        $.ajax({
            url: '/CollaboratorType/Delete', 
            type: 'POST',
            data: { id: activityId },
            success: function (response) {
                if (response.success) {
                    const row = document.getElementById(`row-${activityId}`);
                    if (row) row.remove();
                    alert("tipo de Colaborador excluído com sucesso.");
                } else {
                    alert("Falha ao excluir o tipo de Colaborador.");
                }
            },
            error: function () {
                alert("Ocorreu um erro ao tentar excluir o tipo de Colaborador.");
            }
        });
    }
}