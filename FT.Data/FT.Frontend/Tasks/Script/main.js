$(() => {
    $.ajax({
        url: "./getAll"
    }).done(function (response) {
        tasks = JSON.parse(response);
    });
    $(".panel-group").html("");
    for (var task of tasks) {
        let priority = "default";
        if (task.Priority === "Low") priority = "success";
        else if (task.Priority === "Medium") priority = "warning";
        else if (task.Priority === "High") priority = "danger";
        let descprev = task.Description.substring(0, 12);
        if (descprev !== task.Description) descprev += "...";
        $(".panel-group").append(CreateTaskPreview(task, priority, descprev));
        for (var comment of taskComments) {
            if (comment.TaskId !== task.Id) continue;
            var user = users.find((x) => { return x.Id === comment.UserId });
            $(".comments" + comment.TaskId).append(CreateTaskComment(comment, user));
        }
        $(".comments" + task.Id).append(`<div class="col-md-10">
                    <div class="status-upload">
                        <form>
                            <textarea placeholder="What do you think about it?"></textarea>
                            <button type="submit" class="btn btn-success green">Share</button>
                        </form>
                    </div>
            </div>`);
    }
    
});

var tasks = [
    {
        Id: "123",
        Title: "MyTitle",
        Description: "Супермегаважное задание",
        DateCreated:  "22/01/2018",
        Priority: "Low",
        Type: "OK",
        State: "Fire"
    },
    {
        Id: "124",
        Title: "MyTitle2",
        Description: "Mегаважное задание",
        DateCreated: "22/01/2018",
        Priority: "High",
        Type: "OK",
        State: "Fire"
    }
];
var users = [
    {
        Id:"5",
        FirstName:"Progger",
        LastName:"Micky",
        Email:"somemail@mail.com",
        HashPassword:"japgofaempocnpwxmom23543c9260",
        LastLogin:Date.now()
    },
    {
        Id:"1",
        FirstName:"Team",
        LastName:"Lead",
        Email:"somem2ail@mail.com",
        HashPassword:"jap35vgofaempocnpwxmom23543c9260",
        LastLogin:Date.now()
    }
];
var taskComments = [
    {
        Id: "123",
        Text: "WTF",
        DateCreated: "22/01/2018",
        TaskId: "123",
        UserId: "5"
    },
    {
        Id: "124",
        Text: "It's OK",
        DateCreated: "23/01/2018",
        TaskId: "123",
        UserId: "1"
    },
    {
        Id: "125",
        Text: "Hah",
        DateCreated: "24/01/2018",
        TaskId: "123",
        UserId: "5"
    },
    {
        Id: "126",
        Text: "Nice",
        DateCreated: "25/01/2018",
        TaskId: "123",
        UserId: "5"
    }
];


function CreateTaskPreview(task, priority, descpreview) {
    return `<div class="panel panel-${priority}" data-toggle="modal" style="margin-top: 5px" data-target="#task${task.Id}">
        <div class="panel-heading task-heading">${task.Title}</div>
        <div class="panel-body task-body">${descpreview}</div>

        </div>
    </div>
<div class="modal fade" id="task${task.Id}" role="dialog">
            <div class="modal-dialog">
      <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">${task.Title}</h4>
                    </div>
                    <div class="modal-body">
                        <p>Description: ${task.Description}</p>
                        <p>Date: ${task.DateCreated}</p>
                        <p>Type: ${task.Type}</p>
                        <p>State: ${task.State}</p>
                        <div class="comments${task.Id}"></div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>`;
}

function CreateTaskComment(comment, user) {
    return `<div class="col-sm-10">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <strong>${user.FirstName} ${user.LastName}</strong> <span class="text-muted">${comment.DateCreated}</span>
                        </div>
                        <div class="panel-body">
                            ${comment.Text}
                        </div>
                    </div>
                </div>`;
}